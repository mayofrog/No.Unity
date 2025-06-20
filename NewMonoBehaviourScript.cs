using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int health = 30;
    int level = 5;
    float strength = 15.5f;
    string playerName = "��Ƽ";
    bool isFullLevel = true;
    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.����
        
        

        //2.�׷��� ����
        string[] monsters = {"������", "�縷��", "�Ǹ�"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("�̴Ϲ���30");

        //3.������
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);

        string title = "������";
        string fullName = title + " " + playerName;

        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level > 10;

        //-----------------------------------------------------------
        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "����" : "����";
        //-----------------------------------------------------------

        //4.Ű���� : ���α׷��� �� �����ϴ� Ư���� �ܾ�
        // int float string bool new List - �����̸� ������ ��� �Ұ���


        //5.���ǹ� : ���ǿ� �����ϸ� ������ �����ϴ� ���
        if (condition == "����"){
            Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
        }
        else{
            Debug.Log("�÷��̾� ���°� �����ϴ�.");
        }
        if(isBadCondition && items[0] == "������30"){
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        else if(isBadCondition && items[0] == "��������30"){
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }

        switch (monsters[1]){
            case "������":
            case "�縷��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            default:
                Debug.Log("??? ���Ͱ� ����!");
                break;
        }
        //6.�ݺ��� : ���ǿ� �����ϸ� ������ �ݺ��ϴ� ���
        while (health > 0){
            health--;
            if(health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�. " + health);
            else
                //Debug.Log(" ����Ͽ����ϴ�");
            if(health == 10)
            {
                //Debug.Log("�ص����� ����մϴ�. ");
                break;
            }    
        }

        for (int count=0; count<10; count++)
        {
            health++;
        }

        foreach (string monster in monsters)
        {
            //Debug.Log("�� ������ �ִ� ���� : " + monster);
        }

        Heal();

        for(int index=0; index < monsters.Length; index++)
        {
            //Debug.Log("����" + monsters[index] + "���� " +
            //    Battle(monsterLevel[index]));
        }

        //8.Ŭ����
        Player player = new Player();
        player.id = 0;
        player.name = "��Ƽ";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + " �Դϴ�.");

        Debug.Log(player.move());
    }
    //7.�Լ�
    void Heal()
    {
        health += 10;
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�";

        return result;
    }
}

