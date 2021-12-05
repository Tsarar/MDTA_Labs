using MDTA_Labs.Model.Variant_20;
using System.Collections.Generic;

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
    }
}
