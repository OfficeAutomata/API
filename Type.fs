type TaskExport =
    {
        ProcessID: int
        WorkflowID: int
        Index: int
        UI_Element: string
        AutoID_Control: string
        UI_Element_Pattern: string
        Pattern_Value: string
        X_Path: string
        Type: string
        Value: string
        Time: DateTime
        AppFile: string
        AppFrame_1: string
        User: string
        Location: string
        Application: string
        Data: string
    }

type ProcessExport =
    {
        ProcessID: int
    }