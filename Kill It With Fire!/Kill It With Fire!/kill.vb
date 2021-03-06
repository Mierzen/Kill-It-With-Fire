﻿Module kill
    Public promptResult As String
    Public killed As Integer

    Public Sub kill()
        Dim table As New DataTable
        table.Columns.Add("Process name", GetType(String))
        table.Columns.Add("Process path", GetType(String))
        table.Columns.Add("Status", GetType(String))

        Dim listProcesses(,) As String = _
        { _
        {"C:\Program Files\Cucusoft\NetGuard\SysMsgProxySrvc.sys", "Cucusoft SysMsg Proxy Service"}, _
        {"C:\Program Files (x86)\Common Files\Adobe\ARM\1.0\armsvc.exe", "Adobe Acrobat Update Service"}, _
        {"C:\Program Files\SAMSUNG\USB Drivers\25_escape\conn\ss_conn_service.exe", "SAMSUNG Mobile Connectivity Service"}, _
        {"C:\Program Files (x86)\The Panel Station\The Panel Station Application\PanelStationNotificationService.exe", "PanelManagementNotificationService"}, _
        {"C:\Program Files\NVIDIA Corporation\NvStreamSrv\nvstreamsvc.exe", "NVIDIA Streamer Service"}, _
        {"C:\Program Files (x86)\Common Files\Microsoft Shared\Phone Tools\CoreCon\11.0\bin\IpOverUsbSvc.exe", "Windows Phone IP over USB Transport (IpOverUsbSvc)"}, _
        {"C:\Program Files (x86)\TeamViewer\Version9\TeamViewer_Service.exe", "A"}, _
        {"C:\Program Files (x86)\Common Files\Adobe\ARM\1.0\armsvc.exe", "A"}, _
        {"C:\Program Files\Bonjour\mDNSResponder.exe", "A"}, _
        {"C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\AppleMobileDeviceService.exe", "A"}, _
        {"C:\Program Files (x86)\NVIDIA Corporation\3D Vision\nvSCPAPISvr.exe", "A"}, _
        {"C:\Program Files (x86)\Google\Update\GoogleUpdate.exe", "A"}, _
        {"C:\Program Files\iPod\bin\iPodService.exe", "A"}, _
        {"C:\ProgramData\IePluginServices\PluginService.exe", "A"} _
        }
        For Each p In System.Diagnostics.Process.GetProcesses()
            Try
                Dim currentProcess As String = p.Modules(0).FileName

                For i = 0 To listProcesses.Length / 2 - 1
                    If Strings.StrComp(currentProcess, listProcesses(i, 0)) = 0 Then
                        Dim str As String = "Are you sure you want to kill " & p.ProcessName & "? "

                        If promptResult <> "YesAll" Or promptResult <> "NoAll" Then
                            Prompt.label_procCurrent.Text = str
                            Prompt.label_procDetails.Text = "(" & currentProcess & ")"
                            Prompt.ShowDialog()
                        End If

                        If promptResult = "No" Then
                            Exit For
                        ElseIf promptResult = "NoAll" Then
                            Exit Sub
                        Else '"Yes" or "YesAll"
                            p.Kill()
                            p.WaitForExit() ' // possibly with a timeout

                            table.Rows.Add(p.ProcessName, currentProcess, "Killed")
                            killed += 1
                        End If
                    End If
                Next



                '    catch ( Win32Exception winException )
                '    {
                '                '// process was terminating or can't be terminated - deal with it
                '    }
                '    catch ( InvalidOperationException invalidException )
                '    {
                '                '// process has already exited - might be able to let this one go
                '     }
                '}

            Catch w As System.ComponentModel.Win32Exception
                'do nothing

            Catch e As Exception
                Console.WriteLine("The following exception was raised: ")
                Console.WriteLine(e.Message)
                table.Rows.Add("name", "path", "Failed: " & e.Message)
            End Try
        Next

        form_results.DataGridView1.DataSource = table
    End Sub

    Public Sub center(control As Control, form As Form)
        control.Location = New Point(Math.Round((form.Width - control.Width) / 2, 0), control.Location.Y)
    End Sub
End Module
