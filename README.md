# How to show the popup when selecting the same record again in .NET-MAUI-DataGrid (SfDataGrid) ?
In this article, we will show you how to show the popup when selecting the same record again in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## Xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<Grid>
    <syncfusion:SfDataGrid x:Name="sfGrid"
                           GridLinesVisibility="Both"
                           HeaderGridLinesVisibility="Both"
                           ColumnWidthMode="Auto"
                           SelectionMode="Single"
                           NavigationMode="Cell"
                           AutoGenerateColumnsMode="None"
                           CellTapped="sfGrid_CellTapped"
                           ItemsSource="{Binding Employees}">

        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                              Format="#"
                                              HeaderText="Employee ID" />
            <syncfusion:DataGridTextColumn MappingName="Name"
                                           HeaderText="Employee Name" />
            <syncfusion:DataGridTextColumn MappingName="Title"
                                           HeaderText="Designation" />
            <syncfusion:DataGridDateColumn MappingName="HireDate"
                                           HeaderText="Hire Date" />

        </syncfusion:SfDataGrid.Columns>

    </syncfusion:SfDataGrid>

    <!-- Syncfusion SfPopup -->
    <sfPopup:SfPopup x:Name="popup"
                     WidthRequest="400"
                     HeightRequest="250"
                     ShowFooter="True"
                     ShowHeader="True"
                     StaysOpen="False"
                     IsOpen="{Binding IsPopupOpen, Mode=TwoWay}"
                     >

        <sfPopup:SfPopup.HeaderTemplate>
            <DataTemplate>
                <Label Text="Employee Details" HorizontalOptions="Center"
                       FontSize="18"
                       FontAttributes="Bold" />
            </DataTemplate>
        </sfPopup:SfPopup.HeaderTemplate>

        <sfPopup:SfPopup.ContentTemplate>
            <DataTemplate>
                <VerticalStackLayout Padding="10">
                    <Label 
                           Text="{Binding SelectedEmployeeDetails}"
                           FontSize="16"
                           TextColor="Black" />
                </VerticalStackLayout>
            </DataTemplate>
        </sfPopup:SfPopup.ContentTemplate>

        <sfPopup:SfPopup.FooterTemplate>
            <DataTemplate>
                <Button Text="Close" WidthRequest="100" HeightRequest="40" 
                        Clicked="ClosePopup" />
            </DataTemplate>
        </sfPopup:SfPopup.FooterTemplate>

    </sfPopup:SfPopup>
</Grid>
```

## Xaml.cs
The code below demonstrates how to show the popup when selecting the same record again in SfDataGrid.
```
private void ClosePopup(object sender, EventArgs e)
{
    popup.IsOpen = false;
}

private void sfGrid_CellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
{
    var employee = e.RowData as Employee;
    if (employee != null &&  sfGrid.SelectedRows.Contains(employee))
    { 
        viewModel.UpdateSelectedEmployee(employee);
    }
}

// EmployeeViewModel.cs
public void UpdateSelectedEmployee(Employee employee)
{
    if (employee != null)
    {
        SelectedEmployeeDetails = $"ID: {employee.EmployeeID}\nName: {employee.Name}\nPosition: {employee.Title}";
        IsPopupOpen = true;
    }
}
```

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1ODY1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.l35NmuYmqvl2upVM4jU0E16k0xkdRZsi6YBi6aRxLdU" width=800/>

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-show-the-popup-when-selecting-the-same-record-again-in-.NET-MAUI-DataGrid-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to show the popup when selecting the same record again in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!