using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        });
        var context = await browser.NewContextAsync();

        var page = await context.NewPageAsync();

        await page.GotoAsync("https://localhost:7077/");

        await page.GetByPlaceholder("Email").ClickAsync();

        await page.GetByPlaceholder("Email").FillAsync("yoel@wi-bash.fr");

        await page.GetByPlaceholder("Mot de Passe").ClickAsync();

        await page.GetByPlaceholder("Mot de Passe").FillAsync("Yoel971#");

        await page.GetByRole(AriaRole.Button, new() { Name = "S'identifier" }).ClickAsync();

        await page.GetByPlaceholder("Recherche").ClickAsync();

        await page.GetByRole(AriaRole.Button).First.ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Tenants Azure AD" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Button).First.ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Sociétés" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Karukero a1e924c7-f470-43f9-8c27-a7826f67876c Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Karukero a1e924c7-f470-43f9-8c27-a7826f67876c Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Karukero a1e924c7-f470-43f9-8c27-a7826f67876c Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Button).First.ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Services" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Clientèle finance Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Clientèle finance Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Clientèle finance Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Button).First.ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Profils" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Retour à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Exploitation Editer Utilisateurs Editer Services Delete" }).GetByRole(AriaRole.Link, new() { Name = "Editer Utilisateurs" }).ClickAsync();

        await page.GetByRole(AriaRole.Button, new() { Name = "Quitter" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Exploitation Editer Utilisateurs Editer Services Delete" }).GetByRole(AriaRole.Link, new() { Name = "Editer Services" }).ClickAsync();

        await page.GotoAsync("https://localhost:7077/Role/UpdateServices/0259484e-19fe-4c7a-a4c0-1870b51f2f28");

        await page.GotoAsync("chrome-error://chromewebdata/");

        await page.GotoAsync("https://localhost:7077/Role/Index");

        await page.GetByRole(AriaRole.Row, new() { Name = "Exploitation Editer Utilisateurs Editer Services Delete" }).GetByRole(AriaRole.Link, new() { Name = "Delete" }).ClickAsync();

        await page.GetByRole(AriaRole.Button).First.ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Utilisateurs", Exact = true }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Button).First.ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Rapports" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Retour à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Commission_filter 03530192-f97f-4b2a-9f67-54721604fb00 757dfada-5ec5-4e54-b015-415fc4eb72b2 Commercial Digitom Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Commission_filter 03530192-f97f-4b2a-9f67-54721604fb00 757dfada-5ec5-4e54-b015-415fc4eb72b2 Commercial Digitom Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Row, new() { Name = "Commission_filter 03530192-f97f-4b2a-9f67-54721604fb00 757dfada-5ec5-4e54-b015-415fc4eb72b2 Commercial Digitom Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await page.GetByRole(AriaRole.Button, new() { Name = "Déconnexion" }).ClickAsync();

        await page.GetByPlaceholder("Email").ClickAsync();

        await page.CloseAsync();

    }
}
