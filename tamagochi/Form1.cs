using Timer = System.Windows.Forms.Timer;

namespace tamagochi
{
    public partial class Form1 : Form
    {
      
        
        Pet cat= new Cat("barsick");
        Pet dog = new Dog("bobick");
        Pet fish = new Fish("nemo");
        Pet mutant = new mutant("mutant");
        int index_pet_list = 0;
       public List<Pet> pet_list = new List<Pet>();
       Pet pet = pet_list[index_pet_list];
        
        delegate void Way_to_death();
        delegate string? Death();
        event Way_to_death Way_to_death_event;
      

        public Form1()
        {
            InitializeComponent();
            pet_list.Add(cat);
            pet_list.Add(dog);
            pet_list.Add(fish);
            pet_list.Add(mutant);
            
            kind_animal.Text = pet_list[index_pet_list].ToString ();
            // timer1.Start();
            //var pet = pet_list[index_pet_list];

            Way_to_death way_To_satiety = cat.Increment_satiety;
            Way_to_death way_To_thirst= cat.Increment_thirst;
            Way_to_death_event  = way_To_satiety;
            Way_to_death_event += way_To_thirst;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Way_to_death_event();
            if ((cat.courage >=0) & (cat.satiety >= 0))
            {
                thirst.Value = cat.thirst;
                starve.Value = cat.satiety;
            }
            if ((cat.thirst== 0)| (cat.satiety==0))
            {

                Thread death_thread = new Thread(Death_rimer);

               void Death_rimer () 
                {
                    TimerCallback tcb = new TimerCallback(Death);
                    void Death(object obj)
                    {
                        if (obj is Animal)
                        {
                            next_animal.Text = "Death";
                                //Animal.Finalize();
                        }
                    }
                    System.Threading.Timer timer2 =new System.Threading.Timer(tcb, null,0, 30 * 60 * 1000);
                    

                };
            }
        }

        private void feed_Click(object sender, EventArgs e)
        {
            pet.feed();
        }

        private void drink_Click(object sender, EventArgs e)
        {
            pet.drink();
        }

        private void play_Click(object sender, EventArgs e)
        {
            pet.play();
        }

        private void next_animal_Click(object sender, EventArgs e)
        {
            if (index_pet_list < pet_list.Count - 1)
            {
                index_pet_list++;
            kind_animal.Text = pet_list[index_pet_list].ToString();
            }
           else index_pet_list = 0;
        }

        private void tame_Click(object sender, EventArgs e)
        {
            var pet = pet_list[index_pet_list];
            /* §ß§Ö§â§Ö§Ñ§Ý§Ú§Ù§à§Ó§Ñ§Ý §Ó§í§Ô§â§å§Ù§Ü§å §Ó JSON §Ó §Þ§à§Þ§Ö§ß§ä §ã§Þ§Ö§ß§í §Ù§Ó§Ö§â§ñ*/
        }
    }
}