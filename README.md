# 버튼잡기게임(C# 코딩)
## 개요-C# 프로그래밍학습
-핵심기능: 버튼이 마우스를 피해 도망감,폼에 버튼의 좌표가 나옴,
버튼을 클릭시 성공 메세지가 뜸,
버튼을 놓칠시와 클릭시 효과음이 서로 다름,
버튼을 놓칠시 -10점, 버튼을 클릭시 +100점이 계산되어 폼 옆에 써짐,
버튼을 20번 놓치면 게임오버가 되며 재시도를 할 수 있음.

-화면구성: 버튼1 "나를 잡아봐"

## 실행화면-
1단계코드의실행스크린샷-

<img width="802" height="485" alt="스크린샷 2026-03-12 162717" src="https://github.com/user-attachments/assets/c414f596-ccff-46d1-9f62-abec3d438b24" />
<img width="798" height="485" alt="스크린샷 2026-03-12 162654" src="https://github.com/user-attachments/assets/2ad8fcf7-0b70-49d6-a7b5-e91cce36825d" />

"사진1" 위에 마우스 올릴시 "사진2"로 이동

2단계코드의실행스크린샷-

<img width="900" height="483" alt="스크린샷 2026-03-12 165027" src="https://github.com/user-attachments/assets/3a801f99-17c6-4d4b-8ed6-d1424ef5112e" />

"사진3"는 클릭후 성공메세지가 뜨는것

3단계코드의실행스크린샷-

<img width="800" height="484" alt="스크린샷 2026-03-12 170921" src="https://github.com/user-attachments/assets/d996555b-ec98-4788-b686-3af56a997008" />
<img width="794" height="478" alt="스크린샷 2026-03-12 170938" src="https://github.com/user-attachments/assets/08a641f1-fdd7-4b8e-84bc-fe1d7da59523" />
<img width="797" height="482" alt="스크린샷 2026-03-12 170951" src="https://github.com/user-attachments/assets/38dc4d2a-1948-4025-a0fe-bb4553fd85a0" />

"사진4"는 버튼을 놓쳤을때 점수가 10점 감점된것
"사진5"는 버튼 클릭시 점수가 100점 추가된것
"사진6"은 클릭을 많이하여 버튼이 작아진것

4단계코드의실행스크린샷-

<img width="1000" height="548" alt="스크린샷 2026-03-12 173259" src="https://github.com/user-attachments/assets/52e41699-d9b4-4556-80d1-a3cb5f6f85c4" />
<img width="806" height="488" alt="스크린샷 2026-03-12 173310" src="https://github.com/user-attachments/assets/e4defcb5-a42a-4882-9e77-92e255e039cc" />
<img width="800" height="487" alt="스크린샷 2026-03-12 173321" src="https://github.com/user-attachments/assets/00296c8e-8580-4a68-bd7d-611c09b73d30" />

"사진7"은 게임오버시 다시시작할수있는지 묻는 예,아니오 버튼을 보여줌
"사진8"은 "사진7"에서 "예" 버튼을 누를시 게임정보가 초기화되어 처음부터 할수있음을 보여줌
"사진9"는 "사진7"에서 "아니오" 버튼을 누를시 모든 버튼이 비활성화 됨을 보여줌

## 구현시어려웠던점

게임오버 후 재시작 버튼을 만드려면 이벤트 말고 새로운 ResetGame 함수를 만들어야 해서 이부분이 어려웠고
이를 해결하기 위해 ai에게 물어보며 작성함
