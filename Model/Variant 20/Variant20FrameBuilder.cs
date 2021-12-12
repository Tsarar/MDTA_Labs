using MDTA_Labs.Model.FrameModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MDTA_Labs.Model.Variant_20
{
    public static class Variant20FrameBuilder
    {
        private static Frame baseFrame;

        public static Frame GetBaseFrame()
        {
            return new Frame()
            {
                FrameName = "Тип зв'язку",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                    },
                }
            };
        }

        public static Frame GetEncryptedRadioGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Шифрований радіозв'язок",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Немає власника"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування", 
                        OnAdd = (_) => (new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, 1)).ToString()
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування",
                        SlotValue = "12345",
                        OnEdit = (newKey) => "Увага! Код шифрування був змінений на " + newKey
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Не може бути приглушена технічними засобами супротивника, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };
        }

        public static Frame GetEncryptedRadioFrame()
        {
            var baseFrame = GetEncryptedRadioGenericFrame();

            var frame = new Frame()
            { 
                BaseFrame = baseFrame,
                FrameName = "Радіо #341",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Микита",
                        OnDelete = (_) => "Увага! У радіо більше немає власника",
                        OnEdit = (name) => "Увага! У радіо новий власник: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        SlotValue = baseFrame.Slots.Where(x => x.SlotName == "Дата наступного обслуговування").FirstOrDefault().OnAdd(null)
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Не може бути приглушена технічними засобами супротивника, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Микита"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Опис радіо";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Опис радіо"));

            var encryptionSlot = frame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            encryptionSlot.SlotValue = "54321";
            var oldEncryptionSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldEncryptionSlot.OnEdit("54321"));

            return frame;
        }

        public static Frame GetEncryptedRadioFrame2()
        {
            var baseFrame = GetEncryptedRadioGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Радіо #334",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Сергій",
                        OnDelete = (_) => "Увага! У радіо більше немає власника",
                        OnEdit = (name) => "Увага! У радіо новий власник: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        SlotValue = baseFrame.Slots.Where(x => x.SlotName == "Дата наступного обслуговування").FirstOrDefault().OnAdd(null)
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Не може бути приглушена технічними засобами супротивника, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Сергій"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Опис радіо";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Опис радіо"));

            var encryptionSlot = frame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            encryptionSlot.SlotValue = "67890";
            var oldEncryptionSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldEncryptionSlot.OnEdit("67890"));

            return frame;
        }

        public static Frame GetUnencryptedRadioGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Нешифроване радіо",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Немає власника"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        OnAdd = (_) => (new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, 1)).ToString()
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування",
                        SlotValue = "12345",
                        OnEdit = (newKey) => "Увага! Код шифрування був змінений на " + newKey
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Інформація не може бути прочитана за розумний час під час перехоплення противником, Не може бути приглушена технічними засобами супротивника, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };
        }

        public static Frame GetUnencryptedRadioFrame()
        {
            var baseFrame = GetUnencryptedRadioGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Радіо #445",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Микола",
                        OnDelete = (_) => "Увага! У радіо більше немає власника",
                        OnEdit = (name) => "Увага! У радіо новий власник: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        SlotValue = baseFrame.Slots.Where(x => x.SlotName == "Дата наступного обслуговування").FirstOrDefault().OnAdd(null)
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Інформація не може бути прочитана за розумний час під час перехоплення противником, Не може бути приглушена технічними засобами супротивника, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Микола"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Опис нешифрованого радіо";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Опис нешифрованого радіо"));

            return frame;
        }

        public static Frame GetUnencryptedRadioFrame2()
        {
            var baseFrame = GetUnencryptedRadioGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Радіо #446",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Тарас",
                        OnDelete = (_) => "Увага! У радіо більше немає власника",
                        OnEdit = (name) => "Увага! У радіо новий власник: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        SlotValue = baseFrame.Slots.Where(x => x.SlotName == "Дата наступного обслуговування").FirstOrDefault().OnAdd(null)
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Інформація не може бути прочитана за розумний час під час перехоплення противником, Не може бути приглушена технічними засобами супротивника, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Тарас"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Дуже гучне радіо";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Дуже гучне радіо"));

            return frame;
        }

        public static Frame GetLandlineGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Провідне з'єднання",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Немає власника"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        OnAdd = (_) => (new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, 1)).ToString()
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Не потребує попередньої підготовки оточення, яким фізично переміститься інформація, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };
        }

        public static Frame GetLandlineFrame()
        {
            var baseFrame = GetLandlineGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Провідне з'єднання #3",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Військова частина 21",
                        OnDelete = (_) => "Увага! У провідного з'єднання більше немає власника",
                        OnEdit = (name) => "Увага! У провідного з'єднання новий власник: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        SlotValue = baseFrame.Slots.Where(x => x.SlotName == "Дата наступного обслуговування").FirstOrDefault().OnAdd(null)
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Не потребує попередньої підготовки оточення, яким фізично переміститься інформація, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Військова частина 21"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Ця лінія довжиною 200 метрів";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Ця лінія довжиною 200 метрів"));

            return frame;
        }

        public static Frame GetLandlineFrame2()
        {
            var baseFrame = GetLandlineGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Провідне з'єднання #4",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Військова частина 21",
                        OnDelete = (_) => "Увага! У провідного з'єднання більше немає власника",
                        OnEdit = (name) => "Увага! У провідного з'єднання новий власник: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                        SlotValue = baseFrame.Slots.Where(x => x.SlotName == "Дата наступного обслуговування").FirstOrDefault().OnAdd(null)
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Не потребує попередньої підготовки оточення, яким фізично переміститься інформація, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Військова частина 23"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Ця лінія довжиною 250 метрів";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Ця лінія довжиною 250 метрів"));

            return frame;
        }

        public static Frame GetCourierGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Гонець",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Немає війської частини"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування",
                        SlotValue = "Шифр цезаря",
                        OnEdit = (newKey) => "Увага! Ключ шифрування був змінений на " + newKey
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Інформація не може бути прочитана за розумний час під час перехоплення противником, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };
        }

        public static Frame GetCourierFrame()
        {
            var baseFrame = GetCourierGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Гонець Паша",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Полк номер 5",
                        OnDelete = (_) => "Увага! Гонець більше не приписаний до війського формування",
                        OnEdit = (name) => "Увага! Гонець приписаний до нового війського формування: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Інформація не може бути прочитана за розумний час під час перехоплення противником, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Полк номер 5"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Рядовий Петров";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Рядовий Петров"));

            var encryptionSlot = frame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            encryptionSlot.SlotValue = "Шифр цезаря зі зсувом 5";
            var oldEncryptionSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldEncryptionSlot.OnEdit("Шифр цезаря зі зсувом 5"));

            return frame;
        }

        public static Frame GetCourierFrame2()
        {
            var baseFrame = GetCourierGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Гонець Андрій",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Опис",
                        OnEdit = (name) => "Опис був змінений на " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Власник",
                        SlotValue = "Полк номер 12",
                        OnDelete = (_) => "Увага! Гонець більше не приписаний до війського формування",
                        OnEdit = (name) => "Увага! Гонець приписаний до нового війського формування: " + name
                    },
                    new FrameSlot()
                    {
                        SlotName = "Дата наступного обслуговування",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Код шифрування"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Властивості",
                        SlotValue = "Інформація не може бути прочитана за розумний час під час перехоплення противником, Інформація не може бути передана у голосовому форматі",
                    },
                }
            };

            var ВласникSlot = frame.Slots.Where(x => x.SlotName == "Власник").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(ВласникSlot.OnEdit("Полк номер 12"));

            var nameSlot = frame.Slots.Where(x => x.SlotName == "Опис").FirstOrDefault();
            nameSlot.SlotValue = "Рядовий Іванов";
            GlobalLog.ConsoleLog.AppendLine(nameSlot.OnEdit("Рядовий Іванов"));

            var encryptionSlot = frame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            encryptionSlot.SlotValue = "Шифр цезаря зі зсувом 12";
            var oldEncryptionSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Код шифрування").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldEncryptionSlot.OnEdit("Шифр цезаря зі зсувом 12"));

            return frame;
        }
    }
}
