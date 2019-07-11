import { createLabel } from "@/dom/label";
import { createButton } from "@/dom/button";
import { TEXT } from "@/common/lang";
import { emitHoverEvent } from "@/dom/events";
import createDiv from "@/dom/div";

export function createLinkItem(el: HTMLElement, onEdit: () => void) {
  let item = createDiv();
  item.style.borderBottom = "1px solid #eee";
  item.onmouseover = () => {
    el.scrollIntoView();
    emitHoverEvent(el);
  };
  let href = el.getAttribute("href")!;
  let label = createLabel(href);
  label.style.wordBreak = "break-all";
  label.style.width = "84%";
  label.style.display = "inline-block";
  let button = createButton(TEXT.EDIT);
  button.onclick = onEdit;
  button.style.borderRadius = "24px";
  item.appendChild(label);
  item.appendChild(button);
  return {
    item,
    setLabel: (s: string) => (label.innerText = s)
  };
}
