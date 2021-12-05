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
    }
}
