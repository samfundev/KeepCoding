﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// A <see cref="MonoBehaviour"/> with additional caching capabilities. 
    /// </summary>
#pragma warning disable IDE1006 // Naming Styles
    public abstract class CacheableBehaviour : MonoBehaviour
#pragma warning restore IDE1006 // Naming Styles
    {
        private readonly Dictionary<Type, Component[]> _components = new Dictionary<Type, Component[]>();

        /// <summary>
        /// Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="func">The expensive function to call, only if it hasn't ever been called by this method on the current instance before.</param>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The components specified by <typeparamref name="T"/>.</returns>
        public T[] Cache<T>(Func<T[]> func, bool allowNull = false) where T : Component
        {
            if (!_components.ContainsKey(typeof(T)))
                _components.Add(typeof(T), func().NullCheck("The method cannot be null."));

            return allowNull || !_components[typeof(T)].IsNullOrEmpty() ? (T[])_components[typeof(T)] : throw new MissingComponentException($"Tried to get component {typeof(T).Name} from {this}, but was unable to find one.");
        }

        /// <summary>
        /// Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="func">The expensive function to call, only if it hasn't ever been called by this method on the current instance before.</param>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The components specified by <typeparamref name="T"/>.</returns>
        public T Cache<T>(Func<T> func, bool allowNull = false) where T : Component => Cache(() => new[] { func() }, allowNull).FirstOrDefault();

        /// <summary>
        /// Clears the <see cref="Component"/> caches.
        /// </summary>
        public void Clear() => _components.Clear();

        /// <summary>
        /// Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="func">The expensive function to call, only if it hasn't ever been called by this method on the current instance before.</param>
        /// <param name="parameter">The argument to put in the expensive method call.</param>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The components specified by <typeparamref name="T"/>.</returns>
        public T[] Cache<T>(Func<bool, T[]> func, bool parameter = false, bool allowNull = false) where T : Component
        {
            if (!_components.ContainsKey(typeof(T)))
                _components.Add(typeof(T), func(parameter).NullCheck("The method cannot be null."));

            return allowNull || !_components[typeof(T)].IsNullOrEmpty() ? (T[])_components[typeof(T)] : throw new MissingComponentException($"Tried to get component {typeof(T).Name} from {this}, but was unable to find one.");
        }

        /// <summary>
        /// Similar to <see cref="UnityEngine.Object.FindObjectsOfType{T}"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T Find<T>(bool allowNull = false) where T : Component => Cache(FindObjectOfType<T>, allowNull);

        /// <summary>
        /// Similar to <see cref="UnityEngine.Object.FindObjectsOfType{T}"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] Finds<T>(bool allowNull = false) where T : Component => Cache(FindObjectsOfType<T>, allowNull);

        /// <summary>
        /// Similar to <see cref="Component.GetComponent{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T Get<T>(bool allowNull = false) where T : Component => Cache(FindObjectOfType<T>, allowNull);

        /// <summary>
        /// Similar to <see cref="GameObject.GetComponents{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] Gets<T>(bool allowNull = false) where T : Component => Cache(GetComponents<T>, allowNull);

        /// <summary>
        /// Similar to <see cref="Component.GetComponentInChildren{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T GetChild<T>(bool allowNull = false) where T : Component => Cache(GetComponentInChildren<T>, allowNull);

        /// <summary>
        /// Similar to <see cref="GameObject.GetComponentsInChildren{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <param name="includeInactive">Whether it should include inactive components.</param>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] GetChildren<T>(bool includeInactive = false, bool allowNull = false) where T : Component => Cache(GetComponentsInChildren<T>, includeInactive, allowNull);

        /// <summary>
        /// Similar to <see cref="Component.GetComponentInChildren{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T GetParent<T>(bool allowNull = false) where T : Component => Cache(GetComponentInParent<T>, allowNull);

        /// <summary>
        /// Similar to <see cref="GameObject.GetComponentsInParent{T}()"/>, however it caches the result in a dictionary, and will return the cached result if called again.
        /// </summary>
        /// <exception cref="MissingComponentException"></exception>
        /// <typeparam name="T">The type of component to search for.</typeparam>
        /// <param name="includeInactive">Whether it should include inactive components.</param>
        /// <param name="allowNull">Whether it should throw an exception if it sees <see langword="null"/>, if not it will return the default value. (Likely <see langword="null"/>)</param>
        /// <returns>The component specified by <typeparamref name="T"/>.</returns>
        public T[] GetParents<T>(bool includeInactive = false, bool allowNull = false) where T : Component => Cache(GetComponentsInParent<T>, includeInactive, allowNull);
    }
}
