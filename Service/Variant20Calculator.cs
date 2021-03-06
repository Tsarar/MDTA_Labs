using MDTA_Labs.Model;
using MDTA_Labs.Model.Variant_20;
using System.Collections.Generic;
using System.Text;

namespace MDTA_Labs.Service
{
    public class Variant20Calculator
    {
        public List<ShipType> CalculateBestOption(ShipProperties properties)
        {
            var result = new List<ShipType>();

            if (!properties.HasFlag(ShipProperties.option1) &&
                !properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new ShipType
                    {
                        Id = "1",
                        Name = "Танкер"
                    }
                );
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                !properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new ShipType
                    {
                        Id = "2",
                        Name = "Мале універсальне судно"
                    }
                );
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new ShipType
                    {
                        Id = "3",
                        Name = "Рефрижераторне судно"
                    }
                );
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                !properties.HasFlag(ShipProperties.option2) &&
                properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new ShipType
                    {
                        Id = "4",
                        Name = "Підводний човен"
                    }
                );
            }

            return result;
        }

        public List<ShipPropertiesDescription> GetAllProperties()
        {
            return new List<ShipPropertiesDescription>
            {
                new ShipPropertiesDescription
                {
                    Id = ShipProperties.option1,
                    Description = "Висока швидкість перевезення"
                },
                new ShipPropertiesDescription
                {
                    Id = ShipProperties.option2,
                    Description = "Транспортування продуктів, що швидко псуються"
                },
                new ShipPropertiesDescription
                {
                    Id = ShipProperties.option3,
                    Description = "Приховане перевезення вантажів"
                },
                new ShipPropertiesDescription
                {
                    Id = ShipProperties.option4,
                    Description = "Велика вміщуваність"
                },
            };
        }

        public List<ShipPropertiesDescription> GetAllTypes()
        {
            return new List<ShipPropertiesDescription>
            {
                new ShipPropertiesDescription
                {
                    Id = (ShipProperties)4,
                    Description = "Танкер"
                },
                new ShipPropertiesDescription
                {
                    Id = (ShipProperties)2,
                    Description = "Мале універсальне судно"
                },
                new ShipPropertiesDescription
                {
                    Id = (ShipProperties)3,
                    Description = "Рефрижераторне судно"
                },
                new ShipPropertiesDescription
                {
                    Id = (ShipProperties)1,
                    Description = "Підводний човен"
                },
            };
        }

        public string GetSchemeByType(int type)
        {
            switch (type)
            {
                case 1:
                    return "transport_1.png";
                case 2:
                    return "transport_2.png";
                case 3:
                    return "transport_3.png";
                case 4:
                default:
                    return "transport_4.png";
                    break;
            }
        }

        public string GetTask3SchemeByType(int type)
        {
            switch (type)
            {
                case 1:
                    return "variant20_1.png";
                case 2:
                    return "variant20_2.png";
                case 3:
                    return "variant20_3.png";
                case 4:
                    return "variant20_4.png";
                default:
                    return null;
            }
        }

        public List<DiagramType> GetTask3DiagramNames(ShipProperties properties)
        {
            var result = new List<DiagramType>();

            if (!properties.HasFlag(ShipProperties.option1) &&
                !properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Танкер хімовоз",
                        Option = 1
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Танкер нафтеналивний",
                        Option = 2
                    }
                );
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                !properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Мале універсальне Hyundai",
                        Option = 3
                    }
                );
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Рефрижераторне Reefer",
                        Option = 5
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Рефрижераторне X Æ A-12",
                        Option = 6
                    }
                );
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                !properties.HasFlag(ShipProperties.option2) &&
                properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Підводний човен Astitute",
                        Option = 7
                    }
                );
            }

            return result;
        }

        public int GetTask3TypeByProps(ShipProperties properties)
        {
            var result = new List<DiagramType>();

            if (!properties.HasFlag(ShipProperties.option1) &&
                !properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                return 1;
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                !properties.HasFlag(ShipProperties.option4))
            {
                return 2;
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                properties.HasFlag(ShipProperties.option2) &&
                !properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
            {
                return 3;
            }

            if (properties.HasFlag(ShipProperties.option1) &&
                !properties.HasFlag(ShipProperties.option2) &&
                properties.HasFlag(ShipProperties.option3) &&
                properties.HasFlag(ShipProperties.option4))
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
                    return "variant20_1_1.png";
                case 2:
                    return "variant20_1_2.png";
                case 3:
                    return "variant20_2_1.png";
                case 4:
                    return "variant20_2_2.png";
                case 5:
                    return "variant20_3_1.png";
                case 6:
                    return "variant20_3_2.png";
                case 7:
                    return "variant20_4_1.png";
                case 8:
                    return "variant20_4_2.png";
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
                    Variant20FrameBuilder.GetTanker1();
                    break;
                case 2:
                    Variant20FrameBuilder.GetTanker2();
                    break;
                case 3:
                    Variant20FrameBuilder.GetSmall1();
                    break;
                case 5:
                    Variant20FrameBuilder.GetRefr1();
                    break;
                case 6:
                    Variant20FrameBuilder.GetRefr2();
                    break;
                case 7:
                    Variant20FrameBuilder.GetSubmarine();
                    break;

                default:
                    break;
            }

            return GlobalLog.ConsoleLog.ToString();
        }
    }
}
