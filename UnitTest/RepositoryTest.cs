//using Ecommerce_Project.Models.Persistence;
//using Ecommerce_Project.Models.Domain_Classes;

//namespace UnitTest
//{
//    [TestClass]
//    public class RepositoryTest
//    {
//        Repository<TestEntity> repository;
//        TestEntity entity1, entity2, entity3;

//        [TestInitialize]
//        public void Init()
//        {
//            entity1 = new TestEntity() { Id = 0, Name = null };
//            entity2 = new TestEntity() { Id = 1, Name = null };
//            entity3 = new TestEntity() { Id = 2, Name = null };

//            repository = new Repository<TestEntity>(); // Instantiate a new instance of the repository after each test
//        }

//        [TestCleanup]
//        public void Cleanup()
//        {
//            repository.DeleteAll(); // Cleans the repository after each test
//        }

//        [TestMethod]
//        public void Add_Entity_AddedToReposity() // Testing if the repository is able to add an entity correctly
//        {
//            repository.Add(entity1);
//            Assert.IsNotNull(repository.GetAll().Find(x => x.Id == 0));
//        }

//        [TestMethod]
//        public void Delete_Entity_RemovedFromReposity() // Testing if the repository can remove an item
//        {
//            repository.Add(entity1);
//            repository.Add(entity2);
//            repository.Add(entity3);

//            repository.Delete(entity1);

//            Assert.IsNull(repository.GetAll().Find(x => x.Id == 0));
//        }

//        [TestMethod]
//        public void DeleteAll_Entities_RemovedFromRepository() // Testing if the repository can delete all instances
//        {
//            repository.Add(entity1);
//            repository.Add(entity2);
//            repository.Add(entity3);

//            repository.DeleteAll();

//            Assert.AreEqual(0, repository.GetAll().Count());
//        }

//        [TestMethod]
//        public void GetById_Entity_FromRepository() // Testing if the repository is able to retrieve a specific entity based on it's id
//        {
//            repository.Add(entity1);
//            repository.Add(entity2);
//            repository.Add(entity3);

//            TestEntity? entityToBeAsserted = repository.GetById(1);

//            Assert.IsNotNull(entityToBeAsserted);
//        }

//        [TestMethod]
//        public void Update_Entity_FromRepository() // Testing if the repository is able to update an entity
//        {
//            repository.Add(entity1);

//            entity1.Name = "Michael";

//            repository.Update(entity1);

//            Assert.AreEqual("Michael", repository.GetById(0).Name);
//        }

//    }

//    class TestEntity : Model { public string? Name { get; set; } } // This is just a test class for the repository
//}