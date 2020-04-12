using Microsoft.Bot.Schema;
using System.Collections.Generic;

namespace CoreBot.Resources
{
    public static class GetText
    {
        public static string Welcome = "Hola soy IrkaBot!! Estoy aqui para ayudarte con tus alergias y con la diabetes.";

        public static List<CardAction> WelcomeActions_Allergy = new List<CardAction>()
                {
                    new CardAction() { Title = "Añadir Alergias", Type = ActionTypes.ImBack, Value = "Añadir Alergias" },
                    new CardAction() { Title = "Quitar Alergias", Type = ActionTypes.ImBack, Value = "Quitar Alergias" },
                };

        public static List<CardAction> WelcomeActions_Recipe = new List<CardAction>()
                {
                    new CardAction() { Title = "Buscar Receta", Type = ActionTypes.ImBack, Value = "Buscar Receta" },
                    new CardAction() { Title = "Alergenos Receta", Type = ActionTypes.ImBack, Value = "Alergenos Receta" },
                };

        public static List<CardAction> WelcomeActions_NutritionalValue = new List<CardAction>()
                {
                    new CardAction() { Title = "Consultar Valores Nutricionales", Type = ActionTypes.ImBack, Value = "Consultar Valores Nutricionales" },
                };
    }
}
