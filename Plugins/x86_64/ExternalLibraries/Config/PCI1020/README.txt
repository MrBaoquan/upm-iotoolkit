����������
[0] = ParaRR3.XIN0;
[1] = ParaRR3.XIN1;
[2] = ParaRR3.XIN2;
[3] = ParaRR3.XIN3;
[4] = ParaRR3.XEXPP;
[5] = ParaRR3.XEXPM;
[6] = ParaRR3.XINPOS;
[7] = ParaRR3.XALARM;
[8] = ParaRR3.YIN0;
[9] = ParaRR3.YIN1;
[10] = ParaRR3.YIN2;
[11] = ParaRR3.YIN3;
[12] = ParaRR3.YEXPP;
[13] = ParaRR3.YEXPM;
[14] = ParaRR3.YINPOS;
[15] = ParaRR3.YALARM;
[16] = ParaRR4.ZIN0;
[17] = ParaRR4.ZIN1;
[18] = ParaRR4.ZIN2;
[19] = ParaRR4.ZIN3;
[20] = ParaRR4.ZEXPP;
[21] = ParaRR4.ZEXPM;
[22] = ParaRR4.ZINPOS;
[23] = ParaRR4.ZALARM;
[24] = ParaRR4.UIN0;
[25] = ParaRR4.UIN1;
[26] = ParaRR4.UIN2;
[27] = ParaRR4.UIN3;
[28] = ParaRR4.UEXPP;
[29] = ParaRR4.UEXPM;
[30] = ParaRR4.UINPOS;
[31] = ParaRR4.UALARM;


[32] = X������״̬  1 �������� 0 ֹͣ
[33] = Y������״̬  1 �������� 0 ֹͣ
[34] = Z������״̬  1 �������� 0 ֹͣ
[35] = U������״̬  1 �������� 0 ֹͣ


������/ģ�������
[0-31] XYZU ��8���������

## SetDOʱ, δ�õ���ͨ����Ҫ��0

[32-63] StartLVDV�������
��������ֵ(ͨ��32/40/48/56)���п����Ƿ�ִ��StartLVDV����, ����ֵ >0 ʱ����ִ��StartLVDV

[32-39] StartLVDV X��
[32] ����ֵ 0-xxx
[33] DL.Multiple=1;					// ���� (1~500) 
[34] DL.Acceleration = 5000;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[35] DL.Deceleration = 2500;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[36] DL.StartSpeed = 100 ;			// ��ʼ�ٶ�(1~8000)
[37] DL.DriveSpeed = 8000;			// �����ٶ�	(1~8000)	
[38] ����ͨ��
[39] ����ͨ��

[40-47] StartLVDV Y��
[40] ����ֵ 0-xxx
[41] DL.Multiple=1;					// ���� (1~500) 
[42] DL.Acceleration = 5000;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[43] DL.Deceleration = 2500;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[44] DL.StartSpeed = 100 ;			// ��ʼ�ٶ�(1~8000)
[45] DL.DriveSpeed = 8000;			// �����ٶ�	(1~8000)	
[46] ����ͨ��
[47] ����ͨ��

[48-55] StartLVDV Z��
[48] ����ֵ 0-xxx
[49] DL.Multiple=1;					// ���� (1~500) 
[50] DL.Acceleration = 5000;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[51] DL.Deceleration = 2500;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[52] DL.StartSpeed = 100 ;			// ��ʼ�ٶ�(1~8000)
[53] DL.DriveSpeed = 8000;			// �����ٶ�	(1~8000)	
[54] ����ͨ��
[55] ����ͨ��

[56-63] StartLVDV U��
[56] ����ֵ 0-xxx
[57] DL.Multiple=1;					// ���� (1~500) 
[58] DL.Acceleration = 5000;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[59] DL.Deceleration = 2500;			// ���ٶ�(125~1000,000)(ֱ�߼Ӽ��������м��ٶ�һֱ����)
[60] DL.StartSpeed = 100 ;			// ��ʼ�ٶ�(1~8000)
[61] DL.DriveSpeed = 8000;			// �����ٶ�	(1~8000)	
[62] ����ͨ��
[63] ����ͨ��

[64-67] InstStop �������
[64] X ��
[65] Y ��
[66] Z ��
[67] U ��
