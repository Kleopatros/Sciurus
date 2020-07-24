# Design

## User Experience
1. Open application.
2. Display default partition view:
    * Navigation bar at top.
        * Facilitates opening other partitions.
    * Status bar at bottom: total items in view, selected count, selected size.
    * Partition details at left.
        * Search bar at top; simultaneously filters tag list and media view.
        * Tag list fills the remaining space; heatmap with subtle text size variation.
    * Details/editor view at bottom left.
        * One image: subject, author, tags, dimmensions, size.
    * Media details (and editor) at right (or bottom left): 
    * Remainder of view is all media files and groups.

## Data

### Files
* File names are short IDs.
    * Files are associated by sharing IDs, but each retains a unique sortable suffix.
    * A file may be media or text and can each be stored without any associations.
    * A media file may be associated with one text file by sharing filenames (with distinct extensions).
    * Many media files may be grouped by sharing IDs, but while retaining a unique sortable suffix.
        * A text file may be associated with the group by sharing the ID, but without a suffix.
        * Media files in a group may each have an associated text file by sharing the suffix.
    * Text files cannot be grouped otherwise.
* A whitelist of supported file types is maintained.
    * Any file with an unsupported type is read-only and displays a warning.
    * For development, a list of unsupported file types and the number of files of that type is available via the navigation bar.
* Details/editor view:
    * One image selected: subject, author, tags, dimmensions, size.

### Partitions
* Three default partitions: default (top-level directory), inbox, and recycle bin.

## Other Notes
* How to view inbox vs committed?
    * Combine with default, but with indication - would be hard with series and subdirectories.