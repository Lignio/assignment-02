namespace Assignment2;

public class Queries
{
    public IEnumerable<string> Wizards_By_Rowling()
    {
        var wizards = WizardCollection.Create();
        var rowlingWizards = wizards
            .Where(w => w.Creator.Contains("Rowling"))
            .Select(w => w.Name);
        return rowlingWizards;
    }
    public IEnumerable<string> Wizards_By_Rowling_Linq()
    {
        var wizards = WizardCollection.Create();
        var rowlingWizards = from w in wizards
                             where w.Creator.Contains("Rowling")
                             select w.Name;
        return rowlingWizards;
    }

    public int The_First_Sith()
    {
        var wizards = WizardCollection.Create();
        var siths = wizards
            .Where(w => w.Name.StartsWith("Darth") && w.Year != null)
            .Select(w => (w.Year));
        int theFirst = (int)siths.Min()!;
        return theFirst;
    }
    public int The_First_Sith_Linq()
    {
        var wizards = WizardCollection.Create();
        var siths = from w in wizards
                    where w.Name.StartsWith("Darth") && w.Year != null
                    select w.Year;
        int theFirst = (int)siths.Min()!;
        return theFirst;
    }

    public IEnumerable<(string Name, int? Year)> Unique_HP_Wizards()
    {
        var HPBooks = new string[] {
            "Philosopher's Stone",
            "Chamber of Secrets",
            "Prisoner of Azkaban",
            "Goblet of Fire",
            "Order of the Phoenix",
            "Half-Blood Prince",
            "Deathly Hallows",
        };
        var wizards = WizardCollection.Create();
        var HPWizards = wizards
            .Where(w => HPBooks.Contains(w.Medium))
            .Distinct().Select(w => (w.Name, w.Year));
        return HPWizards;
    }
    public IEnumerable<(string Name, int? Year)> Unique_HP_Wizards_Linq()
    {
        var HPBooks = new string[] {
            "Philosopher's Stone",
            "Chamber of Secrets",
            "Prisoner of Azkaban",
            "Goblet of Fire",
            "Order of the Phoenix",
            "Half-Blood Prince",
            "Deathly Hallows",
        };
        var wizards = WizardCollection.Create();
        var HPWizards = from w in wizards
                        where HPBooks.Contains(w.Medium)
                        select (w.Name, w.Year);
        return HPWizards;
    }

    public IEnumerable<(string Creator, string Name)> Wizards_And_Creators() {
        var wizards = WizardCollection.Create();
        var grouped = wizards
            .GroupBy(w => (w.Creator, w.Name))
            .OrderByDescending(g => g.Key)
            .Select(w => w.Key);
        return grouped;
    }
    public IEnumerable<(string Creator, string Name)> Wizards_And_Creators_Linq() {
        var wizards = WizardCollection.Create();
        var grouped = from w in wizards
                        group w by (w.Creator, w.Name) into g 
                        orderby g.Key descending 
                        select g.Key;
        return grouped;
    }
}
