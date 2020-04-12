namespace CoreBot.Resources
{
    public static class GetImages
    {
        private static string blob_url = "https://diabotstorage.blob.core.windows.net/resources/";

        #region Welcome
        public static string welcome_allergy = blob_url + "welcome_allergy.jpeg";
        public static string welcome_nutritional_value = blob_url + "welcome_nutritional_value.jpg";
        public static string welcome_recipe = blob_url + "welcome_recipe.jpg";
        #endregion
    }
}
