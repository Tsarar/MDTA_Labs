using MDTA_Labs.Model;
using MDTA_Labs.Model.Variant_8;
using System.Collections.Generic;
using System.Text;

namespace MDTA_Labs.Service
{
    public class Variant8Calculator
    {
        public List<CommunicationType> CalculateBestOption(CommunicationProperties properties)
        {
            var result = new List<CommunicationType>();

            if (!properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                properties.HasFlag(CommunicationProperties.CantBeRead) &&
                properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new CommunicationType
                    {
                        Id = "1",
                        Name = "Радіозв'язок із шифруванням"
                    }
                );
            }

            if (!properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                !properties.HasFlag(CommunicationProperties.CantBeRead) &&
                properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new CommunicationType
                    {
                        Id = "2",
                        Name = "Радіозв'язок без шифрування"
                    }
                );
            }

            if (properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                !properties.HasFlag(CommunicationProperties.CantBeRead) &&
                properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new CommunicationType
                    {
                        Id = "3",
                        Name = "Гонець"
                    }
                );
            }

            if (properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                properties.HasFlag(CommunicationProperties.CantBeRead) &&
                !properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new CommunicationType
                    {
                        Id = "4",
                        Name = "Захищене провідне з'єднання"
                    }
                );
            }

            return result;
        }

        public List<CommunicationPropertyDescription> GetAllProperties()
        {
            return new List<CommunicationPropertyDescription>
            {
                new CommunicationPropertyDescription
                {
                    Id = CommunicationProperties.CantBeRead,
                    Description = "Інформація не може бути прочитана за розумний час під час перехоплення противником"
                },
                new CommunicationPropertyDescription
                {
                    Id = CommunicationProperties.CantBeSuppressed,
                    Description = "Інформація не може бути приглушена технічними засобами супротивника"
                },
                new CommunicationPropertyDescription
                {
                    Id = CommunicationProperties.CanSendSound,
                    Description = "Інформація може бути передана у голосовому форматі"
                },
                new CommunicationPropertyDescription
                {
                    Id = CommunicationProperties.DoNotNeedSpecialPreparation,
                    Description = "Не потребує попередньої підготовки оточення, яким фізично переміститься інформація"
                },
            };
        }

        public List<CommunicationPropertyDescription> GetAllTypes()
        {
            return new List<CommunicationPropertyDescription>
            {
                new CommunicationPropertyDescription
                {
                    Id = (CommunicationProperties)1,
                    Description = "Радіозв'язок із шифруванням"
                },
                new CommunicationPropertyDescription
                {
                    Id = (CommunicationProperties)2,
                    Description = "Радіозв'язок без шифрування"
                },
                new CommunicationPropertyDescription
                {
                    Id = (CommunicationProperties)3,
                    Description = "Гонець"
                },
                new CommunicationPropertyDescription
                {
                    Id = (CommunicationProperties)4,
                    Description = "Захищене провідне з'єднання"
                },
            };
        }

        public string GetSchemeByType(int type)
        {
            switch (type)
            {
                case 1:
                    return "connection_1.png";
                case 2:
                    return "connection_2.png";
                case 3:
                    return "connection_3.png";
                case 4:
                default:
                    return "connection_4.png";
                    break;
            }
        }

        public string GetTask3SchemeByType(int type)
        {
            switch (type)
            {
                case 1:
                    return "variant8_1.png";
                case 2:
                    return "variant8_2.png";
                case 3:
                    return "variant8_3.png";
                case 4:
                    return "variant8_4.png";
                default:
                    return null;
            }
        }

        public List<DiagramType> GetTask3DiagramNames(CommunicationProperties properties)
        {
            var result = new List<DiagramType>();

            if (!properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                properties.HasFlag(CommunicationProperties.CantBeRead) &&
                properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Радіо #341",
                        Option = 1
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Радіо #334",
                        Option = 2
                    }
                );
            }

            if (!properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                !properties.HasFlag(CommunicationProperties.CantBeRead) &&
                properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Радіо #445",
                        Option = 3
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Радіо #446",
                        Option = 4
                    }
                );
            }

            if (properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                !properties.HasFlag(CommunicationProperties.CantBeRead) &&
                properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Гонець Паша",
                        Option = 5
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Гонець Андрій",
                        Option = 6
                    }
                );
            }

            if (properties.HasFlag(CommunicationProperties.CantBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                properties.HasFlag(CommunicationProperties.CantBeRead) &&
                !properties.HasFlag(CommunicationProperties.DoNotNeedSpecialPreparation))
            {
                result.Add(
                    new DiagramType
                    {
                        Name = "Провідне з'єднання #3",
                        Option = 7
                    }
                );
                result.Add(
                    new DiagramType
                    {
                        Name = "Провідне з'єднання #4",
                        Option = 8
                    }
                );
            }

            return result;
        }

        public string GetTask3SchemeByOption(int option)
        {
            switch (option)
            {
                case 1:
                    return "variant8_1_1.png";
                case 2:
                    return "variant8_1_2.png";
                case 3:
                    return "variant8_2_1.png";
                case 4:
                    return "variant8_2_2.png";
                case 5:
                    return "variant8_3_1.png";
                case 6:
                    return "variant8_3_2.png";
                case 7:
                    return "variant8_4_1.png";
                case 8:
                    return "variant8_4_2.png";
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
                    Variant8FrameBuilder.GetUnencryptedRadioFrame();
                    break;
                case 2:
                    Variant8FrameBuilder.GetUnencryptedRadioFrame2();
                    break;
                case 3:
                    Variant8FrameBuilder.GetEncryptedRadioFrame();
                    break;
                case 4:
                    Variant8FrameBuilder.GetEncryptedRadioFrame2();
                    break;
                case 5:
                    Variant8FrameBuilder.GetLandlineFrame();
                    break;
                case 6:
                    Variant8FrameBuilder.GetLandlineFrame2();
                    break;
                case 7:
                    Variant8FrameBuilder.GetCourierFrame();
                    break;
                case 8:
                    Variant8FrameBuilder.GetCourierFrame2();
                    break;

                default:
                    break;
            }

            return GlobalLog.ConsoleLog.ToString();
        }
    }
}
