using Guilded.NET;
using Guilded.NET.Objects.Events;
using Guilded.NET.Objects.Chat;
using System.Collections.Generic;

namespace ProjectName {
    /// <summary>
    /// List of user bot commands.
    /// </summary>
    public static class CommandList {
        /// <summary>
        /// Responds with `Pong!`
        /// </summary>
        /// <param name="client">Client to post message with</param>
        /// <param name="messageCreated">Message creation event</param>
        /// <param name="command">Name of the command used</param>
        /// <param name="arguments">Command arguments</param>
        [Command("ping", "pong", Description = "Responds with `Pong!`")]
        public static void Ping(IGuildedClient client, MessageCreatedEvent messageCreated, string command, IList<string> arguments) {
            // Sends a message to channel where `ping`/`pong` command was used
            client.SendMessageAsync(messageCreated.ChannelId,
                // Generates a new message with content `Pong!`
                Message.Generate("Pong!")
            );
        }
    }
}