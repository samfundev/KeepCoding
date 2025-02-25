﻿using KeepCoding;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using static KeepCoding.Game.PlayerSettings;

/// <summary>
/// Advanced audio handler. 
/// </summary>
public sealed class AudioScript : CacheableBehaviour
{
    /// <value>
    /// Determines if the <see cref="AudioSource"/> is muted.
    /// </value>
    public bool IsMuted { get => AudioSource.mute; set => AudioSource.mute = value; }

    /// <value>
    /// Determines if the audio source is currently playing.
    /// </value>
    public bool IsPlaying => _audioSource.isPlaying;

    /// <value>
    /// The current volume of the game. Ranges 0 to 100. In the Editor this value will always return 100.
    /// </value>
    public int Game => _isSFX ? SFXVolume : MusicVolume;

    /// <value>
    /// The volume the <see cref="AudioSource"/> is playing at, determined by <see cref="Volume"/> and <see cref="Game"/>.
    /// </value>
    public float Relative => Volume * (Game / 100f);

    /// <value>
    /// The volume of the sound relative to the game.
    /// </value>
    public float Volume { get; set; }

    /// <value>
    /// The audio clips used by the <see cref="UnityEngine.AudioSource"/>s.
    /// </value>
    public AudioClip[] AudioClips { get => _audioClips; set => _audioClips = value; }

    /// <value>
    /// The main <see cref="UnityEngine.AudioSource"/> property. If the field it is referencing is <see langword="null"/> then it adds a component.
    /// </value>
    public AudioSource AudioSource => _audioSource ? _audioSource : _audioSource = gameObject.AddComponent<AudioSource>();

    /// <summary>
    /// Setting this value to true will make the volume relative to <see cref="MusicVolume"/>, and <see cref="SFXVolume"/> otherwise.
    /// </summary>
    [SerializeField]
#pragma warning disable IDE0044 // Add readonly modifier
    private bool _isSFX = true;
#pragma warning restore IDE0044 // Add readonly modifier

    /// <summary>
    /// The <see cref="Array"/> of clips it can play from.
    /// </summary>
    [SerializeField]
    private AudioClip[] _audioClips;

    /// <summary>
    /// The audio source field.
    /// </summary>
    [SerializeField]
    private AudioSource _audioSource;

    private Routine<float, float> _fade;

    /// <summary>
    /// Returns the <see cref="AudioSource"/>.
    /// </summary>
    /// <param name="dynamicAudio">The instance of <see cref="AudioScript"/> to retrieve <see cref="AudioSource"/> from.</param>
    public static explicit operator AudioSource(AudioScript dynamicAudio) => dynamicAudio.AudioSource;

#pragma warning disable IDE0051 // Remove unused private members
    private void Awake()
#pragma warning restore IDE0051 // Remove unused private members
    {
        _fade = this.ToRoutine((Func<float, float, IEnumerator>)TweenFade);

        AudioSource.playOnAwake = false;
        AudioSource.volume = 0;
    }

#pragma warning disable IDE0051 // Remove unused private members
    private void Update() => AudioSource.volume = Relative;
#pragma warning restore IDE0051 // Remove unused private members

    /// <summary>
    /// Fades the audio source to a specific volume from a specified duration of time linearly.
    /// </summary>
    /// <param name="volume">The volume to get to.</param>
    /// <param name="time">The amount of time it takes to get to <paramref name="volume"/>.</param>
    public void Fade(float volume, float time) => _fade.StartOrRestart(volume, time);

    /// <summary>
    /// Pauses playing the clip.
    /// </summary>
    public void Pause() => AudioSource.Pause();

    /// <summary>
    /// Plays a sound, with optional parameters.
    /// </summary>
    /// <remarks>
    /// The sound can be cancelled with this method, but multiple sounds cannot play simultaneously.
    /// </remarks>
    /// <exception cref="NullIteratorException"></exception>
    /// <param name="clip">The sound clip to play.</param>
    /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
    /// <param name="loop">If the sound should be looped.</param>
    /// <param name="priority">The priority of the sound.</param>
    /// <param name="delay">The amount of delay before the sound starts.</param>
    /// <param name="time">The time in the audio it should start playing at.</param>
    /// <param name="pitch">The pitch of the sound.</param>
    public void Play(AudioClip clip, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1)
    {
        Set(clip, loop, priority, delay, pitch, time, volume);
        AudioSource.PlayDelayed(delay);
    }

    /// <summary>
    /// Plays a sound, with optional parameters.
    /// </summary>
    /// <remarks>
    /// The sound can be cancelled with this method, but multiple sounds cannot play simultaneously.
    /// </remarks>
    /// <exception cref="NullIteratorException"></exception>
    /// <exception cref="MissingComponentException"></exception>
    /// <param name="name">The name of the sound clip to play.</param>
    /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
    /// <param name="loop">If the sound should be looped.</param>
    /// <param name="priority">The priority of the sound.</param>
    /// <param name="delay">The amount of delay before the sound starts.</param>
    /// <param name="time">The time in the audio it should start playing at.</param>
    /// <param name="pitch">The pitch of the sound.</param>
    public void Play(string name, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1) => Play(_audioClips.FirstOrDefault(c => c.name == name) ?? throw new MissingComponentException($"There is no sound effect named \"{name}\". List of audio clips from the prefab: {_audioClips.UnwrapToString()}"), loop, priority, delay, pitch, time, volume);

    /// <summary>
    /// Plays a sound, with optional parameters.
    /// </summary>
    /// <remarks>
    /// Multiple sounds can be played simultaneously with this method, however they cannot be cancelled.
    /// </remarks>
    /// <exception cref="NullIteratorException"></exception>
    /// <param name="clip">The sound clip to play.</param>
    /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
    /// <param name="loop">If the sound should be looped.</param>
    /// <param name="priority">The priority of the sound.</param>
    /// <param name="delay">The amount of delay before the sound starts.</param>
    /// <param name="time">The time in the audio it should start playing at.</param>
    /// <param name="pitch">The pitch of the sound.</param>
    public void PlayStackable(AudioClip clip, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1)
    {
        Set(clip, loop, priority, delay, pitch, time, volume);
        AudioSource.PlayOneShot(clip, Relative);
    }

    /// <summary>
    /// Plays a sound, with optional parameters.
    /// </summary>
    /// <remarks>
    /// Multiple sounds can be played simultaneously with this method, however they cannot be cancelled.
    /// </remarks>
    /// <exception cref="NullIteratorException"></exception>
    /// <exception cref="MissingComponentException"></exception>
    /// <param name="name">The name of the sound clip to play.</param>
    /// <param name="volume">The volume of the sound clip relative to the game sound.</param>
    /// <param name="loop">If the sound should be looped.</param>
    /// <param name="priority">The priority of the sound.</param>
    /// <param name="delay">The amount of delay before the sound starts.</param>
    /// <param name="time">The time in the audio it should start playing at.</param>
    /// <param name="pitch">The pitch of the sound.</param>
    public void PlayStackable(string name, bool loop = false, byte priority = 128, float delay = 0, float pitch = 1, float time = 0, float volume = 1) => PlayStackable(_audioClips.FirstOrDefault(c => c.name == name) ?? throw new MissingComponentException($"There is no sound effect named \"{name}\". List of audio clips from the prefab: {_audioClips.UnwrapToString()}"), loop, priority, delay, pitch, time, volume);

    /// <summary>
    /// Stops playing the clip.
    /// </summary>
    public void Stop() => AudioSource.Stop();

    /// <summary>
    /// Unpauses the paused playback of this <see cref="AudioSource"/>.
    /// </summary>
    public void Unpause() => AudioSource.UnPause();

    private void Set(AudioClip clip, bool loop, byte priority, float delay, float pitch, float time, float volume)
    {
        clip.NullCheck("You cannot play an audio clip which is null.");

        Volume = volume;

        AudioSource.clip = clip;
        AudioSource.loop = loop;
        AudioSource.priority = priority;
        AudioSource.pitch = pitch;
        AudioSource.time = time;
    }

    private IEnumerator TweenFade(float to, float time)
    {
        float from = Volume,
            current = 0;

        while (current < time)
        {
            current += Time.deltaTime;

            float end = current / time,
                start = 1 - end;

            Volume = from * start + to * end;

            yield return null;
        }

        Volume = to;
    }
}
