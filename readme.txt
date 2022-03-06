TETRIS 
1. Block Manager - Generate Block when no activated Block there
// active상태인 블럭이 없으면 블럭을 생성,

2. Block - State - active - move down
// 블럭은 상태가 있고, 액티브 상태인 블럭은 자동으로 1초에 한번씩 내려옴
// 블럭은 움직일 수 없는 상태가 되면, 활성화가 풀리고 비활성화 상태가 됨.
// 비활성화 상태인 블럭은 이동할 수 없음.

3. direction input arrow -> move block
// 인풋을 받아서 왼쪽 또는 오른쪽 키를 누루면, 블럭이 왼쪽 또는 오른쪽으로 이동


-----

블럭을 왼쪽, 또는 오른쪽으로 계속 이동 시 킬 수 있도록 해주세요.
왼쪽의 한계치 또는 오른쪽 한계치를 넘지 않도록 해주세요.
블럭이 1초에 한번 아래로 향할 수 있도록 해주세요.
블럭이 빨간색으로 계속 남아있게 해주세요.
Block.cs의 IsActivated를 삭제하고, State 기반으로 만들어 주세요.

아래쪽 한줄이 완성되면 해당 줄의 블럭들의 상태를 변경해주세요.
그 윗줄의 블럭들의 상태를 아래쪽으로 옮겨주세요.
