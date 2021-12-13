using MDTA_Labs.Model.FrameModel;
using System.Collections.Generic;
using System.Linq;

namespace MDTA_Labs.Model.Variant_9
{
    public class Variant9FrameBuilder
    {
        private static Frame baseFrame;

        public static Frame GetBaseFrame()
        {
            return new Frame()
            {
                FrameName = "Несправність авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                    },
                }
            };
        }

        public static Frame GetGeneficFailType1()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність системи живлення",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                        SlotValue = "3 дні",
                        OnDelete = (_) => "Тривалість ремонту видалено, мастер вкаже її після осмотру",
                        OnEdit = (name) => "Осмотр скінчено, очікувана тривалість " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                        SlotValue = "Великі витрата пального, Втрата потужності, Невпевнений запуск"
                    },
                }
            };
        }

        public static Frame GetFail1()
        {
            var baseFrame = GetGeneficFailType1();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність системи живлення легкового авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Критичний"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete(oldtimeSlot.SlotValue));
            timeSlot.SlotValue = oldtimeSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit(oldtimeSlot.SlotValue));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = "3100 грн.";
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit("3100 грн."));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }

        public static Frame GetFail2()
        {
            var baseFrame = GetGeneficFailType1();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність системи живлення вантажного авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Високий"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete(oldtimeSlot.SlotValue));
            timeSlot.SlotValue = oldtimeSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit(oldtimeSlot.SlotValue));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = "3900 грн.";
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit("3900 грн."));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }

        public static Frame GetGeneficFailType2()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність поршневої групи",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                        OnDelete = (_) => "Тривалість ремонту видалено, мастер вкаже її після осмотру",
                        OnEdit = (name) => "Осмотр скінчено, очікувана тривалість " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        SlotValue = "3700 грн."
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                        SlotValue = "Великі витрата пального, Велика кількість диму, Невпевнений запуск, Детонації двигуна"
                    },
                }
            };
        }

        public static Frame GetFail3()
        {
            var baseFrame = GetGeneficFailType2();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність поршневої групи легкового авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Низький"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        SlotValue = "3700 грн.",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                        SlotValue = "Великі витрата пального, Велика кількість диму, Невпевнений запуск, Детонації двигуна"
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete("2 дні"));
            timeSlot.SlotValue = "2 дні";
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit("2 дні"));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            var oldSoctSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = oldSoctSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit(oldSoctSlot.SlotValue));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }

        public static Frame GetFail4()
        {
            var baseFrame = GetGeneficFailType2();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність поршневої групи вантажного авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Середній"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        SlotValue = "3700 грн.",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                        SlotValue = "Великі витрата пального, Велика кількість диму, Невпевнений запуск, Детонації двигуна"
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete("3 дні"));
            timeSlot.SlotValue = "3 дні";
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit("3 дні"));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            var oldSoctSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = oldSoctSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit(oldSoctSlot.SlotValue));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }

        public static Frame GetGeneficFailType3()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }

            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність подушки двигуна",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                        SlotValue = "2 дні",
                        OnDelete = (_) => "Тривалість ремонту видалено, мастер вкаже її після осмотру",
                        OnEdit = (name) => "Осмотр скінчено, очікувана тривалість " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                        SlotValue = "Втрата потужності, Неприродні шуми, Невпевнений запуск, Детонації двигуна"
                    },
                }
            };
        }

        public static Frame GetFail5()
        {
            var baseFrame = GetGeneficFailType3();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність подушки двигуна легкового авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Середній"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete(oldtimeSlot.SlotValue));
            timeSlot.SlotValue = oldtimeSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit(oldtimeSlot.SlotValue));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = "2000 грн.";
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit("2000    грн."));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }

        public static Frame GetFail6()
        {
            var baseFrame = GetGeneficFailType3();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність подушки двигуна вантажного авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Критичний"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete(oldtimeSlot.SlotValue));
            timeSlot.SlotValue = oldtimeSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit(oldtimeSlot.SlotValue));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = "5000 грн.";
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit("5000 грн."));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }

        public static Frame GetGeneficFailType4()
        {
            if (baseFrame == null)
            {
                baseFrame = GetBaseFrame();
            }


            return new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Пошкоджений корпус двигуна",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                        OnDelete = (_) => "Тривалість ремонту видалено, мастер вкаже її після осмотру",
                        OnEdit = (name) => "Осмотр скінчено, очікувана тривалість " + name,
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                        SlotValue = "Втрата потужності, Великі витрата пального, Детонації двигуна"
                    },
                }
            };
        }

        public static Frame GetFail7()
        {
            var baseFrame = GetGeneficFailType4();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність подушки двигуна вантажного авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Високий"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete("3 дні"));
            timeSlot.SlotValue = "3 дні";
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit("3 дні"));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = "3200 грн.";
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit("3200 грн."));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }

        public static Frame GetFail8()
        {
            var baseFrame = GetGeneficFailType4();

            var frame = new Frame()
            {
                BaseFrame = baseFrame,
                FrameName = "Несправність подушки двигуна вантажного авто",
                Slots = new List<FrameSlot>
                {
                    new FrameSlot()
                    {
                        SlotName = "Ступінь несправності",
                        SlotValue = "Низький"
                    },
                    new FrameSlot()
                    {
                        SlotName = "Тривалість ремонту",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Вартість ремонту",
                        OnEdit = (name) => "Вартість визначено: " + name + ", буде добре повідомити про це власнику",
                    },
                    new FrameSlot()
                    {
                        SlotName = "Скарги власників",
                    },
                }
            };

            var timeSlot = frame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            var oldtimeSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Тривалість ремонту").FirstOrDefault();
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnDelete("3 дні"));
            timeSlot.SlotValue = "3 дні";
            GlobalLog.ConsoleLog.AppendLine(oldtimeSlot.OnEdit("3 дні"));

            var costSlot = frame.Slots.Where(x => x.SlotName == "Вартість ремонту").FirstOrDefault();
            costSlot.SlotValue = "2900 грн.";
            GlobalLog.ConsoleLog.AppendLine(costSlot.OnEdit("2900 грн."));

            var oldCharSlot = frame.BaseFrame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            var charSlot = frame.Slots.Where(x => x.SlotName == "Скарги власників").FirstOrDefault();
            charSlot.SlotValue = oldCharSlot.SlotValue;
            GlobalLog.ConsoleLog.AppendLine("Беремо cкарги власників із базового фрейму");

            return frame;
        }
    }
}
