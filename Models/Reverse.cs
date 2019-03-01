using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Reverse {

    class DoublyLinkedListNode {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    class DoublyLinkedList {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter) {
        while (node != null) {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null) {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the reverse function below.

    /*
     * For your reference:
     *
     * DoublyLinkedListNode {
     *     int data;
     *     DoublyLinkedListNode next;
     *     DoublyLinkedListNode prev;
     * }
     *
     */ 
    static DoublyLinkedListNode reverse(DoublyLinkedListNode head) {
        if (head == null){
            return null;
        }

        var list = new List<DoublyLinkedListNode>();
        var cur = head;
        list.Add(cur);
        while(cur.next != null){
            list.Add(cur.next);
            cur = cur.next;
        }

        
        for(var i = list.Count() - 1; i >= 0; i--){
            var t = list[i].next;
            list[i].next = list[i].prev;
            list[i].prev = t;
        }

        return list[list.Count() - 1];
    }

    // static void Main(string[] args) {

    //         DoublyLinkedList llist = new DoublyLinkedList();

            
    //         llist.InsertNode(1);
    //         llist.InsertNode(3);
    //         llist.InsertNode(4);
    //         llist.InsertNode(10);

    //         DoublyLinkedListNode llist1 = reverse(llist.head);

    // }
}
