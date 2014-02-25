import random


random.SystemRandom();

ofile = file("bigFile", "w");
letters="ABCDEFGHIJKLMNOPQRTUVWXYZ"
for i in range(10000):
	set = ''
	for i in range(1024*1024*10):
		num = random.randrange(0, len(letters));
		set = set + letters[num];
	ofile.write(set);
ofile.close()


