if(!$ServerGUIBind)
{
    $remapDivision[$remapCount] = "Gui";
    $remapName[$remapCount] = "Open Server List";
    $remapCmd[$remapCount] = "OpenServerList";
    $remapCount++;
    $ServerGUIBind = true;
}

function OpenServerList(%val)
{
    if(!%val)
        return;

    canvas.pushDialog(JoinServerGUI);
}

package ServerSwitch
{
    function joinServerGui::join(%this)
    {
        if(isObject(LocalClientConnection))
        {
            messageBoxOK("Ooops!","You cannot join servers while you are hosting your own server or in singleplayer mode. Please close your server first.");
            return;
        }
        Parent::join(%this);
    }
};
activatePackage(ServerSwitch);