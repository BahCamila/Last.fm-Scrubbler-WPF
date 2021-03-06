﻿using System;

namespace Scrubbler.Scrobbling.Data
{
  /// <summary>
  /// Interface for an object that can be scrobbled.
  /// </summary>
  public interface IScrobbableObjectViewModel
  {
    /// <summary>
    /// If true, this object should be
    /// scrobbled.
    /// </summary>
    bool ToScrobble { get; set; }

    /// <summary>
    /// If this object is selected in the UI.
    /// </summary>
    bool IsSelected { get; set; }

    /// <summary>
    /// Event that triggers when <see cref="ToScrobble"/>
    /// changes.
    /// </summary>
    event EventHandler ToScrobbleChanged;

    /// <summary>
    /// Event that triggers when <see cref="IsSelected"/>
    /// changes.
    /// </summary>
    event EventHandler IsSelectedChanged;
  }
}