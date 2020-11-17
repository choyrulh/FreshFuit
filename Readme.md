# Fresh Fuit
aplikasi ini seperti konsep kasir untuk menampilkan buah2 an ke dalam keranjang yg dipilih

# Scope & Functionailities
- user dapat menambahkan buah yg dipilih
- user dapat melihat buah yg dipilih
- user dapat dengan mudah memilih buah karena disediakan gambar buah

## How Does it Works
diawalai method ` class Bucket` pada class `Bucket` merupakan menu keranjang dengan mendeklarasikan dengan
``` csharp
 {
        private int capacity;
        private List<Fruit> fruits;

        public Bucket(int capacity)
        {
            this.capacity = capacity;
            this.fruits = new List<Fruit>();
        }

        public void insert(Fruit fruit)
        {
            this.fruits.Add(fruit);
        }

        public void remove(int position)
        {
            this.fruits.RemoveAt(position);
        }

        public List<Fruit> findAll()
        {
            return this.fruits;
        }
        public int getCapacity()
        {
            return this.capacity;
        }
        public int countItems()
        {
            return this.fruits.Count();
        }
    }
```

untuk controllernya kita deklarasikan di class `BucketController`
``` csharp
 class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;
        private MainWindow mainWindow;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ops, Keranjang penuh bro");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("Yey, Berhasil ditambahkan bro");
            }
        }
        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }
        public void removeFruit(Fruit fruit)
        {
            for (int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == fruit.getName())
                {
                    bucket.remove(itemPosition);
                    eventListener.onSucceed("Yey, berhasil dihapus bro");
                }
            }
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
```