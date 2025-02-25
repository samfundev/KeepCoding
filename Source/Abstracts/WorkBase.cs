﻿using System.Collections;
using System.Threading;
using UnityEngine;

namespace KeepCoding
{
    /// <summary>
    /// Abstract class for the <see cref="Work"/> datatype, since the different overloads are similar to each other.
    /// </summary>
    public abstract class WorkBase
    {
        internal WorkBase(bool allowSimultaneousActive, uint maximumThreadsActive)
        {
            AllowSimultaneousActive = allowSimultaneousActive;
            _maximumThreadsActive = maximumThreadsActive;
        }

        /// <value>
        /// Determines whether any thread in this class is running.
        /// </value>
        public bool IsRunning { get; private protected set; }

        /// <value>
        /// Determines whether it should skip on starting a thread if it doesn't allow multiple.
        /// </value>
        public bool AllowSimultaneousActive { get; }

        /// <value>
        /// Counts the number of threads currently active within this class, and all of its overloads.
        /// </value>
        public static uint ThreadsActive { get; private protected set; }

        /// <value>
        /// The thread of the class.
        /// </value>
        public Thread Thread { get; private protected set; }

        private readonly uint _maximumThreadsActive;

        /// <summary>
        /// Interrupts the thread.
        /// </summary>
        public void Stop()
        {
            if (!IsRunning)
                return;

            Thread.Interrupt();

            ThreadsActive--;

            IsRunning = false;
        }

        /// <summary>
        /// Waits until it is allowed to run a thread.
        /// </summary>
        /// <returns><see cref="WaitWhile"/> until <see cref="ThreadsActive"/> is strictly less than <see cref="_maximumThreadsActive"/>.</returns>
        private protected IEnumerator WaitForOtherThreads() => new WaitWhile(() => _maximumThreadsActive <= ThreadsActive);

        /// <summary>
        /// Waits until its own thread is no longer running..
        /// </summary>
        /// <returns><see cref="WaitWhile"/> until <see cref="IsRunning"/> is no longer true.</returns>
        private protected IEnumerator WaitForOwnThread() => new WaitWhile(() => IsRunning);
    }
}
