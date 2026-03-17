# Core Dictionary Management Tool

The Core Dictionary Management Tool (which I will refer to as CDMT from this point on) is a simple tool for creating, editing, encrypting/decrypting, and converting core dictionaries.

## The User Interface

This application has its own user interface with custom elements.

The form (as you can see) differs from the original Windows Forms. It uses the "neXt Window Management System" library, which allows the form to be handled like a normal form.

Since XWMS has not yet been extensively tested, bugs and other problems may occur. However, I have not encountered any to date, meaning this application also serves as a test application for my management system.

With the planned update, the design is also changed. How exactly, I still design next to.

## Compatibility

CDMT-Windows is kept as close as possible to a low-level .NET version (.NET 6.0) to ensure compatibility with legacy Windows systems such as Windows 7, 8, and 8.1.

CDMT-XenDesk needs the minimum version of .NET 8.0 instead of used to .NET 6.0. This ensures safety and easier maintenance.

CDMT-XELA uses the .NET 6.0 version, since the XELA system is completely up to .NET 6.0 based. This supports legacy systems again

With the creation of MaidNVI, many aspects are updated to .NET 8.0 or higher, which excludes legacy systems.

This is then referred to as the ADK (Avean Development Kit) version.

## Current Status

Currently, the Windows version of CDMT is considered obsolete and will not be maintained for the time being. The new XenDesk variant offers an improved uniform UI, which will be used as a basis for other UI. I have uploaded the first test versions, but they still have to be linked to the proper libraries.

The new XenDesk variant has stronger interventions in the window system and can now have several errors in the scaling and the like. With the next updates, a bug fix is more likely to be taken into account instead of adding functions. As a result, the LTE function on the XenDesk system is temporarily paused.

## News and Updates

I am currently testing the new Light Bar for functionality. Because of that, I thought about using the CDMT. This will result in a second version of the system. This will also be the first insight into the new features of XWMS. In the variant, the design of the "Fintou Design Language" will go to a different design template for XenDesk.

This version of CDMT (CDMT-XenDesk) is, as the name suggests, built for the XenDesk system, which is why it will use the Light Bar. 

The second version is "CDMT-Windows", which is the legacy variant, which is currently not supported. This has only a simple window management and is therefore the most stable version. 

The latest version is "CDMT-XELA". The version is specially created for XELA systems. It offers a more touch-friendly input and has no XWMS. The design is also kept simple here to achieve a uniform design language. . 

Also, a "CDMT-Fintou" will be created soon, for Fintou. Everyone will run on the same basis, only that some will have a configuration that uses special libraries (like Light Bar, which is not easy to apply).

## Future Plans

- Inclusion of LTE (Light-Term Encryption) - Currently in a private development and research phase
- AES256 compatibility
- Switching from the ADK to the newer MaidNVI
- Improved window management and design
- Improved compatibility for XELA and especially XenDesk
