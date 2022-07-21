def reverseString(self, s: List[str]) -> None:
    """
    Do not return anything, modify s in-place instead.
    """
    for i in range(len(s)):
        if (i >= len(s) - 1 - i):
            break
        s[i], s[len(s) - 1 - i] = s[len(s) - 1 - i], s[i]
