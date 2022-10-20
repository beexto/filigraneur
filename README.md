# filigraneur
This little executable takes a photo or a folder and put 1 or 2 watermarks on them.

## Usage
- Select an image (needed even for folder usage)
- Select Right watermark (->) OR/AND Select Left watermark (->)
- Click on `preview` to watermark without exporting (if needed)
- Click on `filigraner` to export image with `Préfix filename` as prefix
- Change JPG Quality if needed

### To watermark a folder
**Selected image's folder must be not contain any folder otherwise it will watermark everything under it recursively**
- Click on `Filigraner dossier`
- Then `Start`

# Right Watermark
Should be `PixEirb_22-23.png` or something that you want to appear the same size (image is scaled before watermarking) at the bottom right corner with a 28 pixel guard

This file is in the repo.
# Left watermark
Can be whatever you want. It will applied without scaling at the bottom left corner with a 28 pixel guard.

# Known bugs
- Possible memory leak when exporting multiple single images
- Folder watermarking cannot be stopped
- Watermarking will wreak havoc on your install if launched on `C:`
- Folder watermarking is recursive for some reason


> Written with au moins 1 doigt
