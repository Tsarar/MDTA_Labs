using MDTA_Labs.Model.Variant_9;
using System.Collections.Generic;

namespace MDTA_Labs.Service
{
    public class Variant9Calculator
    {
        public List<Threatment> CalculateBestOption(MechanicalIssue properties)
        {
            var result = new List<Threatment>();

            if (properties.HasFlag(MechanicalIssue.option1) &&
                !properties.HasFlag(MechanicalIssue.option2) &&
                properties.HasFlag(MechanicalIssue.option3) &&
                properties.HasFlag(MechanicalIssue.option4) &&
                !properties.HasFlag(MechanicalIssue.option5) &&
                !properties.HasFlag(MechanicalIssue.option6))
            {
                result.Add(
                    new Threatment
                    {
                        Id = "1",
                        Name = "Несправність системи живлення"
                    }
                );
            }

            if (properties.HasFlag(MechanicalIssue.option1) &&
                properties.HasFlag(MechanicalIssue.option2) &&
                !properties.HasFlag(MechanicalIssue.option3) &&
                properties.HasFlag(MechanicalIssue.option4) &&
                !properties.HasFlag(MechanicalIssue.option5) &&
                !properties.HasFlag(MechanicalIssue.option6))
            {
                result.Add(
                    new Threatment
                    {
                        Id = "2",
                        Name = "Несправність  поршневої групи"
                    }
                );
            }

            if (!properties.HasFlag(MechanicalIssue.option1) &&
                !properties.HasFlag(MechanicalIssue.option2) &&
                properties.HasFlag(MechanicalIssue.option3) &&
                properties.HasFlag(MechanicalIssue.option4) &&
                properties.HasFlag(MechanicalIssue.option5) &&
                properties.HasFlag(MechanicalIssue.option6))
            {
                result.Add(
                    new Threatment
                    {
                        Id = "3",
                        Name = "Несправність  поршневої групи"
                    }
                );
            }

            if (properties.HasFlag(MechanicalIssue.option1) &&
                !properties.HasFlag(MechanicalIssue.option2) &&
                properties.HasFlag(MechanicalIssue.option3) &&
                !properties.HasFlag(MechanicalIssue.option4) &&
                !properties.HasFlag(MechanicalIssue.option5) &&
                properties.HasFlag(MechanicalIssue.option6))
            {
                result.Add(
                    new Threatment
                    {
                        Id = "4",
                        Name = "Пошкодження корпусу двигуна"
                    }
                );
            }

            return result;
        }

        public List<MechanicalIssueDescription> GetAllProperties()
        {
            return new List<MechanicalIssueDescription>
            {
                new MechanicalIssueDescription
                {
                    MechanicalIssue = MechanicalIssue.option1,
                    Description = "Великі витрата пального"
                },
                new MechanicalIssueDescription
                {
                    MechanicalIssue = MechanicalIssue.option2,
                    Description = "Велика кількість диму"
                },
                new MechanicalIssueDescription
                {
                    MechanicalIssue = MechanicalIssue.option3,
                    Description = "Втрата потужності"
                },
                new MechanicalIssueDescription
                {
                    MechanicalIssue = MechanicalIssue.option4,
                    Description = "Не впевнений запуск"
                },
                new MechanicalIssueDescription
                {
                    MechanicalIssue = MechanicalIssue.option5,
                    Description = "Неприродні шуми"
                },
                new MechanicalIssueDescription
                {
                    MechanicalIssue = MechanicalIssue.option6,
                    Description = "Детонації двигуна"
                },
            };
        }
    }
}
