namespace DemoAPI.Demo {
	public interface IDemoRepository {
		Task<DemoModel> GetDefaultModel();
	}

	public class DemoRepository : IDemoRepository {
		public async Task<DemoModel> GetDefaultModel() {
			return new DemoModel() { 
				Title = "Default title",
				Body = "Default body"
			};
		}
	}
}
