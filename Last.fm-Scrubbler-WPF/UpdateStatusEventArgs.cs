﻿namespace Last.fm_Scrubbler_WPF
{
  /// <summary>
  /// EventArgs that contain a new status for the status bar.
  /// </summary>
  public class UpdateStatusEventArgs
  {
    /// <summary>
    /// The new status string.
    /// </summary>
    public string NewStatus
    {
      get { return _newStatus; }
      private set { _newStatus = value; }
    }
    private string _newStatus;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="newStatus">The new status string.</param>
    public UpdateStatusEventArgs(string newStatus)
    {
      NewStatus = newStatus;
    }
  }
}