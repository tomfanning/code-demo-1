namespace TomF.NvmGame
{
    /// <summary>
    /// A valid move
    /// </summary>
    public enum Move
    {
        /// <summary>
        /// Move one square in the direction the piece is facing
        /// </summary>
        Advance,

        /// <summary>
        /// Turn 90 degrees counter-clockwise
        /// </summary>
        TurnLeft,

        /// <summary>
        /// Turn 90 degrees clockwise
        /// </summary>
        TurnRight
    }
}