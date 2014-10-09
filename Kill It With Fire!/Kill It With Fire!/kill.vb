Module kill
    Public Sub kill()
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
                form_main.Label1.Text = currentProcess

                For i = 0 To listProcesses.Length / 2 - 1
                    If Strings.StrComp(currentProcess, listProcesses(i, 0)) = 0 Then
                        Dim r As MsgBoxResult
                        r = MsgBox("Are you sure you want to Kill the following process? " & vbNewLine & currentProcess, MsgBoxStyle.YesNoCancel Or MsgBoxStyle.ApplicationModal Or MsgBoxStyle.MsgBoxSetForeground)

                        If r = MsgBoxResult.Cancel Then
                            Exit For
                        ElseIf r = MsgBoxResult.Yes Then
                            p.Kill()
                            p.WaitForExit() ' // possibly with a timeout
                            MsgBox("Done")
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

            Catch e As Exception
                Console.WriteLine("The following exception was raised: ")
                Console.WriteLine(e.Message)
            End Try
        Next

        form_main.Label1.Text = ""
    End Sub
End Module
