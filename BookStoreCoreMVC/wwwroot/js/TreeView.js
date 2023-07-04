window.addEventListener('load', () => {
    let all_nested_li = document.querySelectorAll(
        ".tree-view .tree-view-body li:has(ul.nested li)"
    );
    all_nested_li.forEach((element) => {
        const para = document.createElement("span");
        para.classList.add("caret");
        element.appendChild(para);
    });

    let toggler = document.querySelectorAll(
        ".tree-view .tree-view-body .caret"
    );
    for (let i = 0; i < toggler.length; i++) {
        toggler[i].addEventListener("click", function () {
            this.parentElement
                .querySelector(".nested")
                .classList.toggle("active");
            this.classList.toggle("caret-down");
        });
    }

    let input_tags = document.getElementsByTagName("input");
    for (let i = 0; i < input_tags.length; i++) {
        input_tags[i].addEventListener("click", function () {
            if (!this.checked) {
                this.checked = false;
            } else {
                let parent_node = this;
                while (parent_node.id != "myUL") {
                    parent_node = parent_node.parentElement;
                    if (parent_node.tagName.toLocaleLowerCase() == "li") {
                        parent_node.querySelector("label > input").checked = true;
                    }
                }
            }
        });
    }


    function collapsed() {
        let ul_tags = document.querySelectorAll(
            ".tree-view > .tree-view-body ul.is-expandable:not(.active)"
        );
        ul_tags.forEach((element) => {
            element.classList.add("active");
        });
        let caret = document.querySelectorAll(
            ".tree-view > .tree-view-body *.caret:not(.caret-down)"
        );
        caret.forEach((element) => {
            element.classList.add("caret-down");
        });
    }

    function expended() {
        let ul_tags_open = document.querySelectorAll(
            ".tree-view > .tree-view-body ul.is-expandable.active"
        );
        ul_tags_open.forEach((element) => {
            element.classList.remove("active");
        });
        let caret_down = document.querySelectorAll(
            ".tree-view > .tree-view-body *.caret.caret-down"
        );
        caret_down.forEach((element) => {
            element.classList.remove("caret-down");
        });
    }

    function clear_inputs() {
        let checked_input = document.querySelectorAll(
            ".tree-view > .tree-view-body input"
        );
        checked_input.forEach((element) => {
            element.checked = false;
        });
    }

    document
        .getElementsByClassName("tree-view")[0]
        .getElementsByClassName("tv-expended-btn")[0]
        .addEventListener("click", function () {
            expended();
        });

    document
        .getElementsByClassName("tree-view")[0]
        .getElementsByClassName("tv-collapsed-btn")[0]
        .addEventListener("click", function () {
            collapsed();
        });

    document
        .getElementsByClassName("tree-view")[0]
        .getElementsByClassName("tv-clear-btn")[0]
        .addEventListener("click", function () {
            clear_inputs();
        });
});