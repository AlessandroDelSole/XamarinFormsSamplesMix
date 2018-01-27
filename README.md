# Xamarin.Forms Samples Mix

This solution contains examples of how to use popular plugins and libraries for Xamarin.Forms, more specifically:

- Lottie, to bring After Effects animations into Xamarin
- Rg.Plugins.PopUp, a library that allows creating popup pages with transparency in Xamarin.Forms
- Plugin.SegmentedControl, a library that replicates in Xamarin.Forms the typical Segmented Control from iOS

Lottie animations' JSON files are in the Android\Assets and iOS\Resources folders respectively.

UWP is not supported in this project, since Lottie for UWP requires some tricks to work.

The project has been built with .NET Standard 2.0, which requires a couple edits to the .csproj file to include the Lottie and PopUp plugins above. If you don't like this, I recommend a Shared project at the moment.
