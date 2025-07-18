using Sources.Runtime.Core.StateMachine;

namespace Sources.Runtime.Gameplay.MiniGames.Fishing
{
    public class FishingMiniGameStateMachine : StateMachine
    {
        public readonly LaunchState LaunchState;
        public readonly GameplayState GameplayState;
        public readonly EndState EndState;

        public IMiniGame CurrentMiniGame;

        public FishingMiniGameStateMachine(FishingMiniGameDependencies dependencies)
        {
            LaunchState = new LaunchState(dependencies);
            GameplayState = new GameplayState(dependencies);
            EndState = new EndState(dependencies);
        }

        public void SetState(EndState endState, bool gameplayResult)
        {
            endState.SetGameplayResult(gameplayResult);
            
            base.SetState(endState);
        }
    }
}