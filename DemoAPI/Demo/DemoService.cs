namespace DemoAPI.Demo {
	public interface IDemoService {
		Task<DemoModel> GetDefaultDemoModel();
	}

	public class DemoService : IDemoService {
		private readonly IDemoRepository demoRepository;

		public DemoService(IDemoRepository demoRepository) {
			this.demoRepository = demoRepository;
		}

		public async Task<DemoModel> GetDefaultDemoModel() {
			return await this.demoRepository.GetDefaultModel();
		}
	}
}
