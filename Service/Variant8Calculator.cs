using MDTA_Labs.Model.Variant_8;
using System.Collections.Generic;

namespace MDTA_Labs.Service
{
    public class Variant8Calculator
    {
        public List<CommunicationType> CalculateBestOption(CommunicationProperties properties)
        {
            var result = new List<CommunicationType>();

            if (properties.HasFlag(CommunicationProperties.CanBeSuppressed) &&
                properties.HasFlag(CommunicationProperties.CanSendSound))
            {
                result.Add(
                    new CommunicationType
                    {
                        Id = "1",
                        Name = "Радіозв'язок із шифруванням"
                    }
                );
            }

            if (properties.HasFlag(CommunicationProperties.CanBeRead) &&
                properties.HasFlag(CommunicationProperties.CanSendSound) &&
                properties.HasFlag(CommunicationProperties.CanBeSuppressed))
            {
                result.Add(
                    new CommunicationType
                    {
                        Id = "2",
                        Name = "Радіозв'язок без шифрування"
                    }
                );
            }

            if (properties.HasFlag(CommunicationProperties.CanBeRead) &&
                properties.HasFlag(CommunicationProperties.CanSendSound))
            {
                result.Add(
                    new CommunicationType
                    {
                        Id = "3",
                        Name = "Гонець"
                    }
                );
            }

            if (properties.HasFlag(CommunicationProperties.NeedsSpecialPreparation) &&
                properties.HasFlag(CommunicationProperties.CanSendSound))
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
                    CommunicationProperty = CommunicationProperties.CanBeRead,
                    Description = "Інформація може бути прочитана за розумний час під час перехоплення противником"
                },
                new CommunicationPropertyDescription
                {
                    CommunicationProperty = CommunicationProperties.CanBeSuppressed,
                    Description = "Може бути приглушена технічними засобами супротивника"
                },
                new CommunicationPropertyDescription
                {
                    CommunicationProperty = CommunicationProperties.CanSendSound,
                    Description = "Інформація може бути передана у голосовому форматі"
                },
                new CommunicationPropertyDescription
                {
                    CommunicationProperty = CommunicationProperties.NeedsSpecialPreparation,
                    Description = "Потребує попередньої підготовки оточення, яким фізично переміститься інформація"
                },
            };
        }
    }
}
