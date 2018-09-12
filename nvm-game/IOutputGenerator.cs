namespace TomF.NvmGame
{
    /// <summary>
    /// Defines the signature of functionality to output information about the current state of the piece.
    /// </summary>
    public interface IOutputGenerator
    {
        /// <summary>
        /// Output information about the current state of the piece in some format represented by a string
        /// </summary>
        /// <param name="piece">The piece to generate information on</param>
        /// <returns>The current state of the piece in some string format</returns>
        string GenerateOutput(Piece piece);
    }
}