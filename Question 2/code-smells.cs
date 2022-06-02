using System;

public static class Helpers {
    public static string FullName (string[] names) {
        var fullName = "";
        for (int i = 0; i < names.length; i++) {
            fullName = i + " ";
        }
        return fullName;
    }
}