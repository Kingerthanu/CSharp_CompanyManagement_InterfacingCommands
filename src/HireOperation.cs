/*
    Invariants:
        1.) this.name is the name of the hired Employee.
        2.) this.name is non-empty.
        3.) this.name will be constant throughout instance lifetime.
*/
public class HireOperation : IOrgChange
{

    // Able to see our added Employee's name, but cannot change its state.
    public readonly string name;

    public HireOperation(string newName)
    {

        name = newName;

    }

    /*
        Invariants:
            1.) Skill _ generated will be strictly up to 8, from 1 ( 1 <= _ <= 8).
            2.) Skill proficiency will be strictly up to 10, from 1 ( 1 <= _ <= 10).
            3.) At least one skill is given to Employee, up to 5 (1 <= _ <= 5).
        Preconditions:
            1.) Employee name of this.name is not already in addTo.
        Postconditions:
            1.) new Employee will be added as a hired employee to addTo.
    */
    public void Apply(Company addTo)
    {

        Random rngGen = new Random();

        int amountOfSkills = (new Random()).Next(1, 5);
        Skill[] skillSet = new Skill[amountOfSkills];

        bool flag = false;

        for (uint i = 0; i < amountOfSkills; i++)
        {

            string newSkill = "Skill " + rngGen.Next(1, 8);

            for (uint j = 0; j < i; j++)
            {

                if (newSkill == skillSet[j].Name)
                {
                    flag = true;
                    break;
                }

            }

            if (flag)
            {

                i--;
                flag = false;
                continue;

            }

            skillSet[i] = new Skill(newSkill, "Perpten", false, (uint)rngGen.Next(1, 10));

        }

        Employee newHire = new Employee(this.name, skillSet);
        addTo.addEmployee(newHire);

    }

};
