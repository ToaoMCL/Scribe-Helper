using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;



namespace DnD_Bot
{
    class EntertainmentCommands
    {


        [Command("degenerate")] [Aliases("degen")]
        [Description("Show your displeasure of degeneracy with this.")]
        public async Task ShowDegeneracy(CommandContext ctx)
        {
            
            var path = Path.Combine(Environment.CurrentDirectory, "Assets/degenaracy.png");
            await ctx.Channel.SendFileAsync(path).ConfigureAwait(false);
        }
    }
}
