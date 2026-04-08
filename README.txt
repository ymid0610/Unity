유니티
버젼 6.3 사용, 가급적이면 lts가 붙은 버젼사용. 굳이 1학기는 아니어도 되긴함
파이썬 < 코딩 쉽게하는 언어. <실제론 안씀
유니티 < 5.0버젼 이후 C#을 씀, 객체지향언어, window와 호환잘됨. 서버 < C#잘해야됨,
개인적으로 C# 공부 필요. 현실적으론 필요한 언어. C#맛보기함. 여름방학때 제대로 C#공부해보기.
언어자체가 db(데이터베이스)의 기능제공 
디자인패턴 읽기. <- 발표 시킴
1학기. 유니티. 2d -> 네트워크는 다루지않음.
2학기 렌더링. 조명. 애니메이션. 인공지능 컴포넌트(길찾기)
교재 따로없음 -> https://docs.unity3d.com/Manual/index.html
Scrpiting을 중점으로함. <- 언어 C#
중간 기말, 그냥 시험봄. 수업진행하다가 중간고사 2주전. (협상. 과제 or 시험), 과제 40퍼로 밸런스패치.
Q : c++ 언리얼과 unity C#의 차이점?
A : 태생자체가 다름. 언리얼은 게임프로젝트 하면서 만든걸, 대형회사에서 소스코드를 엔진화.
unity는 엔진만들려고 여러가지 소스를 사서 만든것. 시행착오 많았다. C#으로 시작해서. 프레임워크. 프로젝트 만듬.
객체지향언어에선 현존하는 가장 좋은 언어.  언리얼에선. 블루프린트 안씀. 전부 c++로함. 유니티는 멀티플랫폼 대상. 6.0에서 정상화되서 좋아졌다. 게임엔진 틀 잘 맞춤. 

built in render pipeline을 쓰면 언리얼과 비슷하게 정해진 파이프 라인에 스크립트를 넣어 만듬. 하지만 비효율적인 경우가있어서.
다른 파이프라인도 제공한다.

목표 : 유니티를 통해 엔진을 배움. 엔진이 어떤동작을 하는지 이론적인 공부. 실제프로그램 만들기

준비 : 읽기자료 시간 충분히가지고 순서대로 읽기. C#언어 공부 필요.

필요 : 객체지향언어. class, interface. 프로그래밍 경험. 

2026.03.09

프로젝트는 여러개의 scene으로 이루어짐. 하나의 스테이지를 scene이라고 부름
scene은 gameobject의 집합이다. gameobject에는 component가 필요하고, component에는 asset이 필요함.

유니티는 asset을 만드는것이 아닌 가져와서 사용하는것.

asset 가져올때, 윈도우탐색기로 복사하면 복사되서 두개, import로 하면 컴퓨터에서 가져오고 복사는 하지않는다.
asset을 복제할 때는, 설정을 다르게 할때 해도됨

유니티 Assets 폴더는 사용해야됨. 그안에다 수정및 등등
유니티의 Scnen은 Assets을 공유해서사용.

파일탐색기를 사용하면 안됨, Assets 폴더안에있는건 유니티 탐색기 권장함.

Hierarchy 계층구조 잘 활용하자..

2026.03.13

프로젝트 뷰, 내 프로젝트를 관리함,
 시프트+딜리트 삭제(대화상자x)
윈도우와 비슷함
규모가 큰 프로젝트에선 폴더, 에셋, 게임오브젝트가 많음 -> 찾아가는 시간이 많이걸림
이름 검색 가능
t: -> 유형, 1: 레이블 -> 이름, 별 -> 즐겨찾기
폴더만들때 기본제공 폴더는 유니티가 정해놔서 같게하면안됨

씬을 만드는것, game object를 만드는것,
game object는 트리 구조로 표현됨.
Scene tree, 부모자식 관계

계층뷰에서 부모가 다르면 같은 이름을 쓸 수 있다.
3d 객체들은 동일한 개체 여러개 존재 불가능
공간구조가 트리의 모양을 가짐. 한덩어리로 논리적표현, 필요하면 구분
계층구조를 보면, 어떤오브젝트는 기능을 가지거나, 논리적으로 그룹핑 하기위한 오브젝트여도. 다 게임오브젝트다.
이것을 유니티에선 계층 관계라고한다.

모든 오브젝트여도, transform component를 가진다.
자식 객체는 부모 객체의 변환(이동/회전)을 상속받는다.
부모의 transform이 변한다고
자식의 위치는 변하진않는다
자식은 부모를 중심으로 위치가 표현됨
이것을 offset이라고 부름

객체 편집할때 여러개 선택해서 인스펙터 뷰 삽가능
인스펙터 뷰 정보
transform -> 윈도우 에디터컨트롤
쌍동그라미 -> 레퍼런스 타입
c# 포인터 x, 레퍼런스만있
레퍼런스 타입 -> 게임오브젝트를 데이터처럼 사용 가능 (포인터와 유사)
다른거 밸류타입 -> 값을 가짐
유니티는 왼손좌표계
반시계 -> 양

유니티 엔진에서 transform scale 값은 무조건 111
법선벡터는 크기가 1이고 면에 수직이여야되는데
변환하면 노멀벡터 바뀜
게임에서 가장중요한건 frame rate

질문: 실시간으로 커지는 모델은 어케함?
scale factor을 사용해서
scaling해라. 변환 scale 쓰지마라..
scale은 기본 1

써도되긴하는데 느려진다

부모 scale 바꾸면 -> 자식 scale도 바꾼게됨
행렬을 그대로 따라감

게임만들땐 정말로 특별하지않으면 111로 쓰도록 하자
scale 음수가되면 그 축 대칭 일어남

더블클릭이나 F눌러서 포커싱가능

2026.03.16
Scene camera -> Game objects들의 집합 즉, scene을 눈으로 확인할 수 있도록 해주는 카메라
유니티 편집기에서 편집의 용도로 사용한다. 게임이 실행이될때는 관계없음
씬 기즈모, 씬카메라 안에 세상의 축을 나타냄
이름 잘 짓기

inspector
transform class가 멤버로
이름, 문자열 이름 옆 체크박스 -> 체크가 되면 이오브젝트는 Active하다
부모가 비활성화되면 자식들도 비활성화된다.
static 체크박스 
static 옆 콤보박스 에 따라 달라짐
static의 의미, 정적인의미의 오브젝트임을 표현
카메라 뒤에있는 물체는 보이지않고 오브젝트가 정적이라면
미리 계산해서 안보이도록 처리할 수 있다
occlusion, 
유니티에서 오브젝트를 쓸때 정적, 동적 굉장히 중요하다.
필요에따라 정적 동적 잘 표현해야한다.

contribute GI -> global il -> 조명처리 부분에서 정적이다. 미리 조명계산 가능
Occluder -> 가려질때 미리 계산
Navigation -> 길찾기 정적

예) 건물, 길등은 정적이여도 문제가 안된다.
앵간하면 일단 static 체크
정적 => 일반적으로 위치가 안바뀜, 조명에 경우 색상, on off, 로 인하여, 정적이라는 의미가 좀 달라질 수 있다.
frame rate 좋아진다.

layer = 32bit
unsigned int 
헥사가 아닌 문자열로 표현하면 내부적으로 알아서 바꿔줌

tag => 별명
tag로 프로그램 실행중에 충돌처리를할때 예외처리 할수 있다.
tag로 그룹핑 가능
내가 사용

layer은
카메라 에서사용
물리시스템 충돌검사 사용 -> layer에서만 충돌검사 하도록 가능하다.
유니티엔진이 사용

culling Mask 를 이용해 layer에 있는 물체만 렌더링 가능하다.
everything -> 모든레이어 렌더링.
layer은 기본적으로 default로 만들어진다. 

layer override -> include layer 에서 layer 선택가능
exclude로 제외가능
physics Setting에서 layer을 선택가능하다.

프로젝트 설정 -> Physics Settings -> 
물리엔진은 체크박스형태로 가능하기때문에 계산을 빠르게 할수있다.

다음시간에 component
eclass 제공 모델의 mesh 압축해제시 meterial 폴더를 mesh폴더안에 집어넣기
texture도 메쉬 안에
그리고 unity asset 폴더로 복사붙여넣기
하면 잘된다 -> 연습하기

26.03.23

local 좌표계 = object 좌표계

부모자식 관계면 자식의 좌표는 부모의 좌표를 원점으로 하여 표현된다.
방향또한 부모의 방향을 기준으로 함.

Root 게임 오브젝트
월드좌표의 원점과 xyz축을 기준으로 표현한다.

root 게임 오브젝트가 아닌 오브젝트는
부모를 기준으로해서 표현한다.

모든 객체는 하나의 부모를 가짐
부모는 여러자식 가능
자식객체는 부모의 트랜스폼 영향을 받음

self 좌표계 -> 나를 기준으로 <- 부모자식관계간 헷갈리지않게?
회전이나 이동에도 변화하지않는 축
축의 방향이 바뀌는거지 xyz축 개념이 바뀌는게아님

유니티 화면좌표계 -> 좌측하단 0 0

기즈모의 회색은 씬카메라의 z축을 기준으로 회전하는것

align view -> 씬카메라를 객체의 위치로 이동후 방향도 게임객체의 방향으로

격자는 월드좌표계의 x,z축
그리드 자석 수치 조정가능, 회전각도도 가능

그리드스내핑 역슬래쉬

숙제 -> 배운내용 활용해서 도시제작

설계해서
계층구조로 표현해서
반복적인일 적게하도록
프리맵 활용하면 좀더 잘할수 있지만
배운내용 활용해서 잘하기

객체지향 언어에서 class 는 컴포넌트 이다.

03.27
A와 B가 부모자식관계라면 A라는 오브젝트의 transform과 B라는 오브제트의 transform은 부모 자식 관계이다.
실제로 계층구조라는 것은 transform의 계층구조이다.

객체지향언어에서 component는 class이다.
결국 component라는 것은 데이터와 동작(액션)들이 한 쌍으로 묶여진 것이다. 이 component가 달라지면 오브젝트간에 동작에 대한 차이가 생길 수 있다.

유니티가 제공하지 않는 Component를 내가 만들어서 연결할 수 있는데 그것을 유니티는 Script라고 부른다.

script
함수 오버라이딩 개념, 기본이 monobehavior class 이다.
모든 클래스는 monobehavior에서 상속받아 실행됨

unity3d.com documention 사이트에 실행순서가 적혀있다.

update > 60분의 1초마다 한번 실행되고
대부분은 start, update를 주로 코딩할거다
on 이 붙은함수는 뭔가가 일어났다는것을 의미
함수를 알아야한다.

0330
script (asset), class 형태로 만듬
Gameobject에 연결을 해서 component로 만들면
그 클래스가 게임오브젝트에 추가가됨.
스크립트 asset을 게임오브젝트의 component로 만듬
게임오브젝트의 멤버변수처럼되면 unity에선 컴포넌트로 불림
하나의 클래스로 합쳐서 포현을해도 괜찮다 라고 하면, script두개를 추가하기보다는
예) MoveAndRotate

unity 엔진엔 frame사이에 호출되는 함수가 정해져있다.
내가만든 script component에 unity엔진은 이 게임오브젝트를 위해 함수를 순차적으로 하도록되어있다.
그 함수가 현재게임오브젝트의 script 컴포넌트에 있으면 내가만든 script가 호출이된다.

정해진 순서대로 일이 발생했을때 실행이된다 해서 event함수라고 부른다.

재정의하면 나의 함수가 호출된다 c++의 virtual처럼 이해해도되고
메세지 처리로 이해해도된다. 개념적으로 유사함.

On이 붙은 함수는 callback 함수이다.

OnBecameVisible 보이는 상태가되면 => 가렸다가 보이면
OnMouseDown
OnCollisonEnter(Collision collision) -> enter stay exit 으로 구성됨. 충돌상태

On으로 시작되지 않는 함수들 , start, awake, update, fixedupdate

update -> 무조건 60분의 1초마다 호출이되는함수

event가 아니다
fixedupdate는 60분의 1초보다 더 빈번하게 호출이됨.

fixed 는 물리엔진이 호출
update는 사용자입력, 키보드나 마우스입력, 터치 입력을 처리하거나
화면에 오브젝트를 그리는일이 일어난 다음에 호출되는 함수가 update함수이다.

프로젝트 설정에 fixed Timestep 을 이용해 수정할 수 있다.

time scale 이 2가되면 게임세상에서 시간은 빨리간다
1보다작으면 게임세상이 천천히간다
마치 슬로우비디오처럼움직이는 느낌이 들게 할 수 있다.

fixed 함수는 fixed Timestep 에따라 호출되는것이 달라진다.
project setting에서 수정가능
default는 천천히 실행되게되있는데
fixed update를 더 자주 호출하면

기본적으로 많이 쓰는거
Awake -> 스크립트라고하는 컴포넌트가 활성화된다 그때한번 호출되는함수
Start -> Update가 호출되기 이전에 딱 한번 호출되는 함수
Update는 프레임마다 호출
LateUpdate는 Update 호출된다음
fixedUpdate는 물리엔진 다음에 물어보는것

Awake 잘안쓰고 start많이씀
lateUpdate를 재정의해서 쓰는경우도 드물다.

start에선 멤버변수를 초기화함
public 멤버변수를 unity 엔진에서 수정하고
저장하면
unity에선 오브젝트의 내용을 저장하고 다시 동작하도록 한다. (인스펙터 뷰에서 바뀐내용)
Serialization 이라고한다.

C# 은 포인터가 없어서
transform 하고 gameobject 포인터처럼 취급해도된다.

transform 은 monoBehaviour라는 스크립트안에서 transform을 쓸 수 있는데.
이 스크립트가 연결이되어있는 gameobject가 가지고 있는 transform을 사용할 수 있도록
클래스 라이브러리를 만들어 놓았다. monobehaviour에서 상속받은
소문자 변수를 쓸 수 있다. 스크립트에 연결이 되어있는 게임오브젝트를 의미한다.

method는 일을 시키는것
transform vector를 주고 translate는 평행이동
overload 되어있어서 다양한 형식으로 사용가능

04.03
script 함수에는 transform 클래스 가 있는데 
public method에 translate라는 함수가 잇다. -> 여러 형태들로 overload가 되어있다. vector를 주고 평행이동하거나, x y z 로도 하고,
space relative to라고 되어있고, space = 어떤 좌표계를 쓸거냐, 게임오브젝트에다가 transform을 적용하기 위한 좌표계를 무엇으로 할지 정할 수 있다.
space.world -> 월드좌표계
space.self -> 자체좌표계 > gameobject의 local		<- default, object의 right up forward 으로 이동하게됨
right up forward라는 3개의 벡터가 있다.  

Time class에 시간관련 제공 이친구들은 static properties라서 Time으로 쓸수있다
deltatime이라는것은 마지막 프레임이 실행이되고 그다음에 얼마나 시간이 지났는지, frame과 frame사이의 간격
유니티는 모든단위 1이 1m이다.
Time.deltaTime -> 1/60, -> transform.Translate(0,0,Time.deltaTime) 인경우 객체의 local z축 방향으로 1/60만큼 이동하라는 의미
Vector3.foraward -> (0,0,1)

04.06
Unity -> Gameobject 또는 Asset을 생성하면, Unity엔진이 알도록 만들어야한다.
객체를 생성하기위한 함수가 Instantiate 함수이다. 동적
유니티에서 생성했던 object를 없애는 함수. Destroy 함수
동적 생성 소멸 시키기위해 사용하는 함수
Gameobject라고 하는 class 는 상속받아 만들어져서 두개의 함수를 가지고 있다.

Prefab -> Gameobject를 Asset으로 만드는 것
Prefab 은 Asset이다.
Scene에 사용되기 위한 데이터를 Asset이라 한다.
Prefab으로 Gameobject를 만들고 component를 지워도 Preafab엔 남아있다.
Asset에서 Prefab에서 component를 지우면 제거가된다.
Prefab은 Asset이면서 Gameobject이다.
Prefab을 만들고 동적으로 생성하는것이 편하다.

Instantiate 에 인자로 prefab을 넘겨서 생성 가능하다.
