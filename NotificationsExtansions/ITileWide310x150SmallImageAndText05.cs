namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays a poster image and two text fields.
    /// </summary>
    public interface ITileWide310x150SmallImageAndText05 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeading { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}