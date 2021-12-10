# mvvmlight-Net Framework 4.7.2

> mvvmlight를 사용하여 mvvm패턴 활성화 및 기본 세팅



## NuGet으로 mvvmlight 설치

- `참조` 우클릭 후 `NuGet 패키지 관리` 클릭

![image-20211210204314492](README.assets/image-20211210204314492.png)



- `찾아보기`로 탭 이동 후 `mvvmlight` 안정적인 버전으로 설치 및 라이센스 동의

![image-20211210204638674](README.assets/image-20211210204638674.png)



- `ViewModelLocator`로 오면 `ServiceLocator`를 불러오지 못 하고 있음.

![image-20211210204920851](README.assets/image-20211210204920851.png)



- `using Microsoft.Practices.ServiceLocation;` 부분을 `﻿using CommonServiceLocator;﻿`로 변경

![image-20211210210220930](README.assets/image-20211210210220930.png)



- `public MainViewModel Main`을 `public MainViewModel MainWindow`로 변경(필수 아님)

![image-20211210210446947](README.assets/image-20211210210446947.png)



- 한번 빌드 후 `MainWindow.xaml`에서 `﻿DataContext="{Binding Source={StaticResource Locator}, Path=MainViewModel}"` 세팅
  - Path 부분은 `ViewModelLocator` 이름 기준

![image-20211210211703457](README.assets/image-20211210211703457.png)





## View 폴더 생성 후 연동

> 필수는 아니지만, View들이 많아질수록 솔루션 탐색기가 더러워지기 때문에 추천하는 방법



- View 폴더 생성 후 `MainWindow`를 하위로 넣어줌

![image-20211210212034554](README.assets/image-20211210212034554.png)



- `MainWindow.xaml.cs`에서 `namespace` 뒤에 `.View` 추가

![image-20211210212242185](README.assets/image-20211210212242185.png)



- `MainWindow.xaml`에서 `X:Class.{{ ProjectName }}.View.MainWindow`로 수정

![image-20211210212409359](README.assets/image-20211210212409359.png)



- `App.xaml`에서 `StartupUri="MainWindow.xaml"`를 `StartupUri="View/MainWindow.xaml"`로 변경

![image-20211210212628478](README.assets/image-20211210212628478.png)

