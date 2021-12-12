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
                FrameName = "Судно",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                    },
                }
            };
        }

        public static Frame GetTankerGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Танкер",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження",
                        OnDelete = (_) => "Судно передано на службу в іншу країну, доки судно не пройде розмитнення, країну не визначено",
                        OnEdit = (name) => "Судно розмитнено, країну змінено на " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                        SlotValue = "Велика вміщуваність"
                    },
                }
            };
        }

        public static Frame GetTanker1()
        {
            var baseFrame = GetTankerGenericFrame();

            var frame = new Frame()
            { 
                BaseFrame = baseFrame,
                FrameName = "Танкер хімовоз",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан",
                        OnEdit = (name) => $"Капітана судна {name.Split("|")[0]} було змінено, у судна новий капітан {name.Split("|")[1]}"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                    },
                }
            };

            var cptSlot = frame.Slots.Where(x => x.SlotName == "Капітан").FirstOrDefault();
            cptSlot.SlotValue = "Lavrenko Orymyr";
            GlobalLog.ConsoleLog.AppendLine(cptSlot.OnEdit(frame.FrameName + "|" + "Lavrenko Orymyr"));

            var countrySlot = frame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            var oldcountrySlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnDelete("Україна"));
            countrySlot.SlotValue = "Україна";
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnEdit("Україна"));

            var yearSlot = frame.Slots.Where(x => x.SlotName == "Рік випуску").FirstOrDefault();
            yearSlot.SlotValue = "2010";

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо характеристики із базового фрейму");

            return frame;
        }

        public static Frame GetTanker2()
        {
            var baseFrame = GetTankerGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Танкер нефтеналивний",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан",
                        OnEdit = (name) => $"Капітана судна {name.Split("|")[0]} було змінено, у судна новий капітан {name.Split("|")[1]}"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                    },
                }
            };

            var cptSlot = frame.Slots.Where(x => x.SlotName == "Капітан").FirstOrDefault();
            cptSlot.SlotValue = "May Browne";
            GlobalLog.ConsoleLog.AppendLine(cptSlot.OnEdit(frame.FrameName + "|" + "May Browne"));

            var countrySlot = frame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            var oldcountrySlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnDelete("США"));
            countrySlot.SlotValue = "США";
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnEdit("США"));

            var yearSlot = frame.Slots.Where(x => x.SlotName == "Рік випуску").FirstOrDefault();
            yearSlot.SlotValue = "2018";

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо характеристики із базового фрейму");

            return frame;
        }

        public static Frame GetSmallGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Мале універсальне",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження",
                        OnDelete = (_) => "Судно передано на службу в іншу країну, доки судно не пройде розмитнення, країну не визначено",
                        OnEdit = (name) => "Судно розмитнено, країну змінено на " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                        SlotValue = "Висока швидкість перевезення, Транспортування продуктів, що швидко псуються"
                    },
                }
            };
        }

        public static Frame GetSmall1()
        {
            var baseFrame = GetSmallGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Мале універсальне Hyundai",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан",
                        OnEdit = (name) => $"Капітана судна {name.Split("|")[0]} було змінено, у судна новий капітан {name.Split("|")[1]}"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                    },
                }
            };

            var cptSlot = frame.Slots.Where(x => x.SlotName == "Капітан").FirstOrDefault();
            cptSlot.SlotValue = "Yeop Kun-Bong";
            GlobalLog.ConsoleLog.AppendLine(cptSlot.OnEdit(frame.FrameName + "|" + "Yeop Kun-Bong"));

            var countrySlot = frame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            var oldcountrySlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnDelete("Корея"));
            countrySlot.SlotValue = "Корея";
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnEdit("Корея"));

            var yearSlot = frame.Slots.Where(x => x.SlotName == "Рік випуску").FirstOrDefault();
            yearSlot.SlotValue = "2010";

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо характеристики із базового фрейму");

            return frame;
        }

        public static Frame GetRefrGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Рефрежираторне",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження",
                        OnDelete = (_) => "Судно передано на службу в іншу країну, доки судно не пройде розмитнення, країну не визначено",
                        OnEdit = (name) => "Судно розмитнено, країну змінено на " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                        SlotValue = "Висока швидкість перевезення, Транспортування продуктів, що швидко псуються, Велика вміщуваність"
                    },
                }
            };
        }

        public static Frame GetRefr1()
        {
            var baseFrame = GetRefrGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Рефрижераторне Reefer",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан",
                        OnEdit = (name) => $"Капітана судна {name.Split("|")[0]} було змінено, у судна новий капітан {name.Split("|")[1]}"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску",
                        SlotValue = "2021"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                    },
                }
            };

            var cptSlot = frame.Slots.Where(x => x.SlotName == "Капітан").FirstOrDefault();
            cptSlot.SlotValue = "Zuwena Uba";
            GlobalLog.ConsoleLog.AppendLine(cptSlot.OnEdit(frame.FrameName + "|" + "Zuwena Uba"));

            var countrySlot = frame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            var oldcountrySlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnDelete("Уганда"));
            countrySlot.SlotValue = "Уганда";
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnEdit("Уганда"));

            var yearSlot = frame.Slots.Where(x => x.SlotName == "Рік випуску").FirstOrDefault();
            yearSlot.SlotValue = "1965";

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо характеристики із базового фрейму");

            return frame;
        }

        public static Frame GetRefr2()
        {
            var baseFrame = GetRefrGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Рефрижераторне X Æ A-12",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан",
                        OnEdit = (name) => $"Капітана судна {name.Split("|")[0]} було змінено, у судна новий капітан {name.Split("|")[1]}"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                    },
                }
            };

            var cptSlot = frame.Slots.Where(x => x.SlotName == "Капітан").FirstOrDefault();
            cptSlot.SlotValue = "Hachiro Kyoko";
            GlobalLog.ConsoleLog.AppendLine(cptSlot.OnEdit(frame.FrameName + "|" + "Hachiro Kyoko"));

            var countrySlot = frame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            var oldcountrySlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnDelete("Японія"));
            countrySlot.SlotValue = "Японія";
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnEdit("Японія"));

            var oldYearSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Рік випуску").FirstOrDefault();
            var yearSlot = frame.Slots.Where(x => x.SlotName == "Рік випуску").FirstOrDefault();
            yearSlot.SlotValue = oldYearSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо рік із базового фрейму (2021)");

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо характеристики із базового фрейму");

            return frame;
        }

        public static Frame GetSubmarineGenericFrame()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Підводний човен",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження",
                        OnDelete = (_) => "Судно передано на службу в іншу країну, доки судно не пройде розмитнення, країну не визначено",
                        OnEdit = (name) => "Судно розмитнено, країну змінено на " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску",
                        SlotValue = "2021"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                        SlotValue = "Висока швидкість перевезення, Приховане перевезення вантажів, Велика вміщуваність"
                    },
                }
            };
        }

        public static Frame GetSubmarine()
        {
            var baseFrame = GetSubmarineGenericFrame();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Підводний човен Astitute",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Капітан",
                        OnEdit = (name) => $"Капітана судна {name.Split("|")[0]} було змінено, у судна новий капітан {name.Split("|")[1]}"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Походження"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Рік випуску"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Характеристики",
                    },
                }
            };

            var cptSlot = frame.Slots.Where(x => x.SlotName == "Капітан").FirstOrDefault();
            cptSlot.SlotValue = "Luis Fletcher";
            GlobalLog.ConsoleLog.AppendLine(cptSlot.OnEdit(frame.FrameName + "|" + "Luis Fletcher"));

            var countrySlot = frame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            var oldcountrySlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Походження").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnDelete("Британія"));
            countrySlot.SlotValue = "Британія";
            GlobalLog.ConsoleLog.AppendLine(oldcountrySlot.OnEdit("Британія"));

            var yearSlot = frame.Slots.Where(x => x.SlotName == "Рік випуску").FirstOrDefault();
            yearSlot.SlotValue = "2012";

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Характеристики").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо характеристики із базового фрейму");

            return frame;
        }
    }
}
