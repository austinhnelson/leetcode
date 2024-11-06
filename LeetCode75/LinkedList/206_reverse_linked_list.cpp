/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* reverseList(ListNode* head) {
        ListNode* prev = NULL;

        while (head != NULL){
            // We will be changing head, in-place, so grab the next iteration
            ListNode* next = head->next;
            // Set the new reversed list's next to the previous value
            head->next = prev;
            // update previous
            prev = head;
            // iterate
            head = next;
        }
        // return last value before null
        return prev;
    }
};