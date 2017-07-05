[설명]

protobuf3를 활용 유니티에서 tcp 통신 사용 가능

packet.xml에 패킷들을 xml형태로 정의해 python스크립트를 통해 *.proto 파일을 자동생성 후 관련 *.cs 파일 만든 후 *.proto 파일들은 삭제


[사용법]

1. create_packet.py 실행하여 패킷을 Assets/Network/Packet 폴더에 패킷관련 파일 생성 및 Asset/Network/Opcode폴더에 opcode.cs 생성

2. 위의 create_packet.py 실행을 위해서 packet_config.ini 값들을 채워줘야 함

3. packet_config.ini은 create_packet.py를 실행하면 자동으로 생성!
