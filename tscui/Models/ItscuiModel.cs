using System;
using System.Collections.Generic;

namespace tscui.Models
{
    /// <summary>
    /// The tscui Model interface.
    /// </summary>
    public interface ItscuiModel
    {
        /// <summary>
        /// Gets the ablums.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetAlbums();

        /// <summary>
        /// Gets the artists.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetArtists();

        /// <summary>
        /// Gets the tracks.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetTracks();
    }
}
