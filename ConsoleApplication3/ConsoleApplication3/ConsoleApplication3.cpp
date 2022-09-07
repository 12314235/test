#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <stdlib.h>

#define N 5

struct student* create(char*, char*, int, int, int, student*);
void show_students(student*);

struct student {
	char* name;
	char* group;
	int isu_number;
	int age;
	int course;
	student* next;
};

void main(){
	char name[100];
	char group[6];
	int isu_number;
	int age;
	int course;
	struct student* head = NULL;
	char fl[4];

	printf("File input?(True/Flase):\n");
	scanf_s("%s\n", &fl);

	if (fl == "False") {
		for (int i = 0; i < N; i++) {
			puts(name);
			puts(group);
			scanf_s("%d\n", &isu_number);
			scanf_s("%d\n", &age);
			scanf_s("%d\n", &course);
			head = create(name, group, isu_number, age, course, head);
		}
	}
	else if(fl == "True") {
		FILE* file = fopen("C:\\Users\\vitsl\\source\\repos\\ConsoleApplication3\\ConsoleApplication3\\input.txt", "r");
		fscanf(file, "%s\n", name);
		printf("%s\n", name);
		fclose(file);
	}

	show_students(head);
}

struct student* create(char* name, char* group, int isu_number, int age, int course, student* head) {
	struct student* element = (struct student*)malloc(sizeof(struct student));
	element->name = name;
	element->group = group;
	element->isu_number = isu_number;
	element->age = age;
	element->course = course;
	element->next = head;
	return element;
}

void show_students(student* element) {
	while (element != NULL) {
		printf("%s\n", element->name);
		printf("%s\n", element->group);
		printf("%d\n", element->isu_number);
		printf("%d\n", element->age);
		printf("%d\n", element->course);
		element = element->next;
		show_students(element);
	}
}