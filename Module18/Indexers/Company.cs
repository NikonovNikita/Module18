namespace Module18.Indexers;

internal class Company
{
    Person[] personal;

    public Company(Person[] people) => personal = people;

    public Person this[int index]
    {
        get => personal[index];
        set => personal[index] = value;
    }
}
