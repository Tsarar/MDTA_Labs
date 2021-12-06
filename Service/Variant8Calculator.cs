using MDTA_Labs.Model.Variant_8;
using System.Collections.Generic;

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
    }
}
