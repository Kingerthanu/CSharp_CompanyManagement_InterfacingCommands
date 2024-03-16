/*
    Invariants:
        1.) this->name is the name of the new Team.
        2.) this->name is non-empty.
        3.) this.name will be constant throughout instance lifetime.
*/
public class CreateTeamOperation : IOrgChange
{

    // Able to see our added teams name, but cannot change its state.
    public readonly string name;

    public CreateTeamOperation(string newName)
    {

        this.name = newName;

    }

    /*
       Preconditions:
           1.) Team name of this->name is not already in addTo's teams.
       Postconditions:
           1.) new Team with this->name will be added to addTo with no Employees.
   */
    public void Apply(Company addTo)
    {

        addTo.createTeam(this.name);

    }

};
