- Big O Notaion => Describes how the number of operations grows as the size of the input increases

- Amortized complexity => average time per operation over a sequence of operations, so usually how much time something will take

- Cache
    - Talking about CPU cache, CPU-s also have memory and this is the cache, the CPU can reach this quickly
    - it has 3 level L1, L2 and L3, as the level grows the bigger and slower it gets but still faster than RAM
    - Modern CPU-s have the alogrythm (LRU) to decide where to place the varaibles
    - Usally what is stored in the cache is also stored in RAM, a copy

- How does the Operating system gives memory to the CPU?
    - It is handled by the operating system in proccess-es called "paging" and "swapping"
    - The operating system gives memory to the CPU in Virtual Memory, so addresses which are connected to values
    - A varaible connected to a Virtual Memory address might not be loaded into RAM, this is where the Memory Management Unit (MMU) comes to play, it translates Virtual Memory addresses into addresses in RAM and it can also signal the operating system if data is needed
    - Pageing => moveing data from dick to RAM in fixed-size blocks (pages)
    - Swapping => Sometimes sysnonim for pageing, but it can also refer to moveing entire processes in and out of RAM
    - Least Recently Used (LRU) Algorithm and Others: Algorithms to decide which page should be moved to memory instead of being part of RAM based on its last usage