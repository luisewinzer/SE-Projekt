class DeceasedPerson
{
    public string name {get; set;}
    public string furtherInformation {get; set;}
    public string birthdate { get; set;}
    public string deathdate {  get; set;}

    public DeceasedPerson(string _name,string _furtherInformation,string _birthdate,string _deathdate)
    {
        name = _name;
        furtherInformation = _furtherInformation;
        birthdate = _birthdate;
        deathdate = _deathdate;

    }

    public void EditInformation (string _furtherInformation)
    {
        furtherInformation = _furtherInformation;
    }
}

