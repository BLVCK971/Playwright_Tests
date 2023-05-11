using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task MyTest()
    {
        await Page.GotoAsync("https://localhost:7077/");

        await Page.GetByPlaceholder("Email").ClickAsync();

        await Page.GetByPlaceholder("Email").FillAsync("https://localhost:7077/");

        await Page.GetByPlaceholder("Email").ClickAsync();

        await Page.GetByText(".cls-1 { fill: #fff; } .cls-2 { fill: #355ea9; } Business Zone S'identifier").ClickAsync();

        await Page.GetByPlaceholder("Email").ClickAsync();

        await Page.GetByPlaceholder("Email").FillAsync("Yoel@wi-bash.fr");

        await Page.GetByPlaceholder("Email").PressAsync("Tab");

        await Page.GetByPlaceholder("Mot de Passe").FillAsync("Yoel971#");

        await Page.GetByRole(AriaRole.Button, new() { Name = "S'identifier" }).ClickAsync();

        await Page.GetByPlaceholder("Recherche").ClickAsync();

        await Page.GetByRole(AriaRole.Combobox).SelectOptionAsync(new[] { "null" });

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Tenants Azure AD" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "Karukero Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.Locator("div").Filter(new() { HasText = ".cls-1 { fill: #fff; } .cls-2 { fill: #355ea9; } #Logo { align-items: center; ju" }).First.ClickAsync();

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Tenants Azure AD" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByLabel("Nom du service").ClickAsync();

        await Page.GetByLabel("Nom du service").FillAsync("sasdsd");

        await Page.GetByLabel("Identifiant du Tenant Azure").ClickAsync();

        await Page.GetByLabel("Identifiant du Tenant Azure").FillAsync("qsdqsdq");

        await Page.GetByLabel("Identifiant du Client Azure").ClickAsync();

        await Page.GetByLabel("Identifiant du Client Azure").FillAsync("qsdqsd");

        await Page.GetByLabel("Identifiant Secret du Client Azure").ClickAsync();

        await Page.GetByLabel("Identifiant Secret du Client Azure").FillAsync("qsdqsd");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Créer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "sasdsd Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByLabel("Identifiant du Client Azure").ClickAsync();

        await Page.GetByLabel("Identifiant du Client Azure").FillAsync("qsdqsdsdsd");

        await Page.GetByLabel("Identifiant du Tenant Azure").ClickAsync();

        await Page.GetByLabel("Identifiant du Tenant Azure").FillAsync("qsdqsdqsdsd");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "sasdsd Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "sasdsd Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Sociétés" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByLabel("Nom").ClickAsync();

        await Page.GetByLabel("Nom").FillAsync("qsdqs");

        await Page.GetByLabel("Identifiant Espace de Travail PowerBI").ClickAsync();

        await Page.GetByLabel("Identifiant Espace de Travail PowerBI").FillAsync("qsdqsd");

        await Page.GetByRole(AriaRole.Button, new() { Name = "-- Selectionnez --" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "-- Selectionnez --" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Créer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsdqs qsdqsd Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "-- Selectionnez --" }).ClickAsync();

        await Page.GetByRole(AriaRole.Menuitem, new() { Name = "Test1@Monsieur.fr" }).ClickAsync();

        await Page.Locator("div").Filter(new() { HasText = "Nom Identifiant Espace de Travail PowerBI Test1@Monsieur.fr regis.geromegnace@gm" }).Nth(1).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsdqs qsdqsd Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsdqs qsdqsd Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Services" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByLabel("Nom du service").ClickAsync();

        await Page.GetByLabel("Nom du service").FillAsync("qsdqsd");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Créer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsdqsd PKTrading Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByLabel("Nom du service").ClickAsync();

        await Page.GetByLabel("Nom du service").FillAsync("qsdqsdqsdqsd");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsdqsdqsdqsd PKTrading Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Détails" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsdqsdqsdqsd PKTrading Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Profils" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByLabel("Nom du Role").ClickAsync();

        await Page.GetByLabel("Nom du Role").FillAsync("sqdqsd");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Créer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByLabel("Nom du Role").ClickAsync();

        await Page.GetByLabel("Nom du Role").FillAsync("qsfqsfqsfqsdqsd");

        await Page.GetByRole(AriaRole.Button, new() { Name = "Créer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsfqsfqsfqsdqsd Editer Utilisateurs Editer Services Delete" }).GetByRole(AriaRole.Link, new() { Name = "Editer Utilisateurs" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Quitter" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsfqsfqsfqsdqsd Editer Utilisateurs Editer Services Delete" }).GetByRole(AriaRole.Link, new() { Name = "Editer Services" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "qsfqsfqsfqsdqsd Editer Utilisateurs Editer Services Delete" }).GetByRole(AriaRole.Link, new() { Name = "Delete" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Quitter" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Utilisateurs", Exact = true }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button).First.ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Rapports" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { Name = "Nouveau" }).ClickAsync();

        await Page.GetByLabel("Nom du rapport").FillAsync("s");

        await Page.GetByLabel("Nom du rapport").ClickAsync();

        await Page.GetByLabel("Nom du rapport").FillAsync("sdqsfq");

        await Page.GetByLabel("Identifiant Espace de travail PowerBI").ClickAsync();

        await Page.GetByLabel("Identifiant Espace de travail PowerBI").FillAsync("qsdqsfdqs");

        await Page.GetByLabel("Identifiant Rapport PowerBI").ClickAsync();

        await Page.GetByLabel("Identifiant Rapport PowerBI").FillAsync("sdqsdsqd");

        await Page.GetByRole(AriaRole.Combobox, new() { Name = "Service associé" }).SelectOptionAsync(new[] { "11d94eda-4921-411a-a811-08db26fe53b4" });

        await Page.GetByRole(AriaRole.Combobox, new() { Name = "Tenant associé" }).SelectOptionAsync(new[] { "2" });

        await Page.GetByRole(AriaRole.Button, new() { Name = "Créer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "sdqsfq qsdqsfdqsq sdqsdsqd Exploitation Digitom Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Modifier" }).ClickAsync();

        await Page.GetByRole(AriaRole.Combobox, new() { Name = "Service associé" }).SelectOptionAsync(new[] { "268222a1-62cf-44ab-25f9-08db3d28c7db" });

        await Page.GetByRole(AriaRole.Combobox, new() { Name = "Tenant associé" }).SelectOptionAsync(new[] { "1" });

        await Page.GetByRole(AriaRole.Button, new() { Name = "Modifier" }).ClickAsync();

        await Page.GotoAsync("https://localhost:7077/Report/Edit/4a2df92e-3f2a-46f1-1862-08db473ecf70");

        await Page.GetByRole(AriaRole.Link, new() { Name = "Revenir à la liste" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "sdqsfq qsdqsfdqsq sdqsdsqd Exploitation Digitom Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "sqdqsfqsf qsdqsdqs q Qualité Digitom Modifier Détails Supprimer" }).GetByRole(AriaRole.Link, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Supprimer" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Déconnexion" }).ClickAsync();

        await Page.GetByPlaceholder("Email").ClickAsync();

    }
}
