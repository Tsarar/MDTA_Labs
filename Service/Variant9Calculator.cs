using MDTA_Labs.Model;
using MDTA_Labs.Model.Variant_9;
using System.Collections.Generic;
using System.Text;

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
                    Id = MechanicalIssue.option1,
                    Description = "Великі витрати пального"
                },
                new MechanicalIssueDescription
                {
                    Id = MechanicalIssue.option2,
                    Description = "Велика кількість диму"
                },
                new MechanicalIssueDescription
                {
                    Id = MechanicalIssue.option3,
                    Description = "Втрата потужності"
                },
                new MechanicalIssueDescription
                {
                    Id = MechanicalIssue.option4,
                    Description = "Не впевнений запуск"
                },
                new MechanicalIssueDescription
                {
                    Id = MechanicalIssue.option5,
                    Description = "Неприродні шуми"
                },
                new MechanicalIssueDescription
                {
                    Id = MechanicalIssue.option6,
                    Description = "Детонації двигуна"
                },
            };
        }

        public List<MechanicalIssueDescription> GetAllTypes()
        {
            return new List<MechanicalIssueDescription>
            {
                new MechanicalIssueDescription
                {
                    Id = (MechanicalIssue)2,
                    Description = "Несправність системи живлення"
                },
                new MechanicalIssueDescription
                {
                    Id = (MechanicalIssue)1,
                    Description = "Несправність  поршневої групи"
                },
                new MechanicalIssueDescription
                {
                    Id = (MechanicalIssue)3,
                    Description = "Несправність подушки двигуна"
                },
                new MechanicalIssueDescription
                {
                    Id = (MechanicalIssue)4,
                    Description = "Пошкодження корпусу двигуна"
                },
            };
        }

        public string GetSchemeByType(int type)
        {
            switch (type)
            {
                case 1:
                    return "car_1.png";
                case 2:
                    return "car_2.png";
                case 3:
                    return "car_3.png";
                case 4:
                default:
                    return "car_4.png";
                    break;
            }
        }

        public string GetTask3SchemeByType(int type)
        {
            switch (type)
            {
                case 1:
                    return "variant9_1.png";
                case 2:
                    return "variant9_2.png";
                case 3:
                    return "variant9_3.png";
                case 4:
                    return "variant9_4.png";
                default:
                    return null;
            }
        }

        public List<DiagramType> GetTask3DiagramNames(MechanicalIssue properties)
        {
            var result = new List<DiagramType>();

            if (properties.HasFlag(MechanicalIssue.option1) &&
                !properties.HasFlag(MechanicalIssue.option2) &&
                properties.HasFlag(MechanicalIssue.option3) &&
                properties.HasFlag(MechanicalIssue.option4) &&
                !properties.HasFlag(MechanicalIssue.option5) &&
                !properties.HasFlag(MechanicalIssue.option6))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Несправність системи живлення легкового авто",
                        Option = 1
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Несправність системи живлення вантажного авто",
                        Option = 2
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
                    new DiagramType
                    {
                        Name = "Несправність поршневої групи легкового авто",
                        Option = 3
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Несправність поршневої групи вантажного авто",
                        Option = 4
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
                    new DiagramType
                    {
                        Name = "Несправність подушки двигуна легкового авто",
                        Option = 5
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Несправність подушки двигуна вантажного авто",
                        Option = 6
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
                    new DiagramType
                    {
                        Name = "Пошкодження корпусу двигуна легкового авто",
                        Option = 7
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Пошкодження корпусу двигуна вантажного авто",
                        Option = 8
                    }
                );
            }

            return result;
        }

        public int GetTask3TypeByProps(MechanicalIssue properties)
        {
            if (properties.HasFlag(MechanicalIssue.option1) &&
                !properties.HasFlag(MechanicalIssue.option2) &&
                properties.HasFlag(MechanicalIssue.option3) &&
                properties.HasFlag(MechanicalIssue.option4) &&
                !properties.HasFlag(MechanicalIssue.option5) &&
                !properties.HasFlag(MechanicalIssue.option6))
            {
                return 1;
            }

            if (properties.HasFlag(MechanicalIssue.option1) &&
                properties.HasFlag(MechanicalIssue.option2) &&
                !properties.HasFlag(MechanicalIssue.option3) &&
                properties.HasFlag(MechanicalIssue.option4) &&
                !properties.HasFlag(MechanicalIssue.option5) &&
                !properties.HasFlag(MechanicalIssue.option6))
            {
                return 2;
            }

            if (!properties.HasFlag(MechanicalIssue.option1) &&
                !properties.HasFlag(MechanicalIssue.option2) &&
                properties.HasFlag(MechanicalIssue.option3) &&
                properties.HasFlag(MechanicalIssue.option4) &&
                properties.HasFlag(MechanicalIssue.option5) &&
                properties.HasFlag(MechanicalIssue.option6))
            {
                return 3;
            }

            if (properties.HasFlag(MechanicalIssue.option1) &&
                !properties.HasFlag(MechanicalIssue.option2) &&
                properties.HasFlag(MechanicalIssue.option3) &&
                !properties.HasFlag(MechanicalIssue.option4) &&
                !properties.HasFlag(MechanicalIssue.option5) &&
                properties.HasFlag(MechanicalIssue.option6))
            {
                return 4;
            }

            return 0;
        }

        public string GetTask3SchemeByOption(int option)
        {
            switch (option)
            {
                case 1:
                    return "variant9_1_1.png";
                case 2:
                    return "variant9_1_2.png";
                case 3:
                    return "variant9_2_1.png";
                case 4:
                    return "variant9_2_2.png";
                case 5:
                    return "variant9_3_1.png";
                case 6:
                    return "variant9_3_2.png";
                case 7:
                    return "variant9_4_1.png";
                case 8:
                    return "variant9_4_2.png";
                default:
                    return null;
            }
        }

        public string GetTask3LogByOption(int option)
        {
            GlobalLog.ConsoleLog = new StringBuilder();

            switch (option)
            {
                case 1:
                    Variant9FrameBuilder.GetFail1();
                    break;
                case 2:
                    Variant9FrameBuilder.GetFail2();
                    break;
                case 3:
                    Variant9FrameBuilder.GetFail3();
                    break;
                case 4:
                    Variant9FrameBuilder.GetFail4();
                    break;
                case 5:
                    Variant9FrameBuilder.GetFail5();
                    break;
                case 6:
                    Variant9FrameBuilder.GetFail6();
                    break;
                case 7:
                    Variant9FrameBuilder.GetFail7();
                    break;
                case 8:
                    Variant9FrameBuilder.GetFail8();
                    break;

                default:
                    break;
            }

            return GlobalLog.ConsoleLog.ToString();
        }
    }
}
