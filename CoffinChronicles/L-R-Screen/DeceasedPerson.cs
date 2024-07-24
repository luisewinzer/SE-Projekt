class DeceasedPerson
{
    private string name {get; set;}
    private string furtherInformation {get; set;}
    private DateTime birthdate = new DateTime():
    private DateTime deathdate = new DateTime();

    public DeceasedPerson()
    {

    }

    public void EditInformation (string _furtherInformation)
    {
        furtherInformation = _furtherInformation;
    }
}

