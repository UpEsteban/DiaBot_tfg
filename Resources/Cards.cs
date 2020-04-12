using Microsoft.Bot.Schema;
using System.Collections.Generic;

namespace CoreBot.Resources.Cards
{
    public static class Cards
    {
        public static List<Attachment> Welcome()
        {
            var attachments = new List<Attachment>
            {
                GenerateHeroCard("Alergias", string.Empty, string.Empty, new List<CardImage>{ GenerateCardImage("Alergias",GetImages.welcome_allergy)}, GetText.WelcomeActions_Allergy).ToAttachment(),
                GenerateHeroCard("Recetas", string.Empty, string.Empty, new List<CardImage>{ GenerateCardImage("Recetas",GetImages.welcome_recipe)}, GetText.WelcomeActions_Recipe).ToAttachment(),
                GenerateHeroCard("Valores Nutricionales", string.Empty, string.Empty, new List<CardImage>{ GenerateCardImage("Valores Nutricionales",GetImages.welcome_nutritional_value)}, GetText.WelcomeActions_NutritionalValue).ToAttachment()
            };

            return attachments;
        }

        private static HeroCard GenerateHeroCard(string tittle, string subtitle, string text,
            List<CardImage> images, List<CardAction> buttons)
            => new HeroCard
            {
                Title = tittle,
                Subtitle = subtitle,
                Text = text,
                Images = images,
                Buttons = buttons
            };

        private static CardImage GenerateCardImage(string alternativeText, string url) => new CardImage { Alt = alternativeText, Url = url };
    }
}
